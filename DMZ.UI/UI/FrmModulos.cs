using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DataTable = System.Data.DataTable;

namespace DMZ.UI.UI
{
    public partial class FrmModulos : FrmClasse
    {
        private Modulos _modulos;

        public FrmModulos()
        {
            InitializeComponent();
        }

        private void FrmModulos_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Modulos";
        }

        public override void DefaultValues()
        {
            _modulos = DoAddline<Modulos>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_modulos);
            EF.Save(_modulos);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _modulos = FillControls(_modulos, dt, i);
            _modulosfrmdoc = gridUi1.GetBindedTable();
        }

        private DataTable _dtForms;

        private void CallFormList(bool b,string origem)
        {
            _modulosfrmdoc = gridUi1.GetBindedTable();
            if (_dtForms?.Rows.Count>0)
            {
                var f = new FrmFormList {gridUi1 = {DataSource = null}};
                f.gridUi1.SetDataSource(_dtForms);
                f.Enviar = Receber;
                f.Isdoc = b;
                f.label1.Text=origem;
                f.ShowDialog(this);
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MsBox.Show("Não tem formulários definidos para este módulo");
            }
        }

        private void CreateTable()
        {
            _dtForms = new DataTable();
            var dc1 = new DataColumn("Ecran",typeof(string));
            _dtForms.Columns.Add(dc1);
            var dc2 = new DataColumn("Descricao",typeof(string));
            _dtForms.Columns.Add(dc2);
            var dc4 = new DataColumn("Origem",typeof(string));
            _dtForms.Columns.Add(dc4);
            var dc3 = new DataColumn("Ok",typeof(bool));
            _dtForms.Columns.Add(dc3);
            var dc5 = new DataColumn("Oristamp",typeof(string));
            _dtForms.Columns.Add(dc5);
            var dc6 = new DataColumn("sigla", typeof(string));
            _dtForms.Columns.Add(dc6);
        }

        public void Receber(DataTable dt,bool isdoc =false)
        {
            if (!dt.HasRows()) return;
            //Helper.DoProgressProcess(dt, DoMethod3);
            DoMethod3(dt);
        }

        private DataTable _modulosfrmdoc;
        private void DoMethod3(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                if (_modulosfrmdoc.HasRows())
                {
                    //NewMethod1(_modulosfrmdoc, r);
                    var existe = _modulosfrmdoc.AsEnumerable().Where(x => x.RowState != DataRowState.Deleted).Any(x => x.Field<string>("ecran").Equals(r["ecran"].ToString().Trim()));
                    if (!existe)
                    {
                        NewMethod1(_modulosfrmdoc, r);
                    }
                }
                else
                {
                    NewMethod1(_modulosfrmdoc, r);
                }
            }
            gridUi1.Invokex(x => x.SetDataSource(_modulosfrmdoc));
            IsDoc = false;
        }

        private void NewMethod1(DataTable dt2, DataRow r)
        {
            var row = dt2.NewRow().Inicialize();
            row["Modulosfrmdocstamp"] = Pbl.Stamp();
            row["Modulosstamp"] = CLocalStamp;
            row["ecran"] = r["ecran"];
            row["descricao"] = r["descricao"];
            row["Isdoc"] = IsDoc;
            row["Origem"] = r["Origem"];
            row["Oristamp"] = r["Oristamp"];//
            row["sigla"] = r["ecran"];
            dt2.Rows.Add(row);
        }

        private void DoMethod(DataTable dt)
        {
            if (true)
            {
                foreach (var row in dt.AsEnumerable())
                {
                    if (row!=null)
                    {
                        var dr = _dtForms.NewRow();
                        dr["Ecran"] = row["Ecran"];
                        dr["Descricao"] = row["Descricao"];
                        dr["Ok"] = false;
                        dr["Origem"] = row["Origem"];//Oristamp
                        dr["Oristamp"] = row["Oristamp"];//
                        dr["sigla"] = row["sigla"];//
                        _dtForms.Rows.Add(dr);
                    }
                }
            }
            gridUi1.Invokex(x => x.Update());
        }

        public bool IsDoc { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CreateTable();
            IsDoc = true;
            string xx = $@"select * from (
                                select sigla as ecran, descricao,Origem='tdoc', tdocstamp as Oristamp,sigla from tdoc where tdocstamp not in (select Oristamp from Modulosfrmdoc)
                                union all 
                               select sigla as ecran, descricao,Origem='tdi',tdistamp as Oristamp,sigla from tdi where tdistamp not in (select Oristamp from Modulosfrmdoc)
                                union all 
                               select sigla as ecran, descricao,Origem='tdocf',tdocfstamp as Oristamp,sigla  from tdocf where tdocfstamp not in (select Oristamp from Modulosfrmdoc)
                                union all 
                               select sigla as ecran, descricao,Origem='TRcl',trclstamp as Oristamp,sigla  from TRcl where TRclstamp not in (select Oristamp from Modulosfrmdoc)
                                union all 
                               select sigla as ecran, descricao,Origem='Tpgf',Tpgfstamp as Oristamp,sigla  from Tpgf where Tpgfstamp not in (select Oristamp from Modulosfrmdoc))tmp1 where Oristamp not in (select Oristamp from Modulosfrmdoc)
                                ";
            var dtDoc = SQL.GetGen2DT(xx);
            if (!(dtDoc?.Rows.Count > 0)) return;
            //Helper.DoProgressProcess(dtDoc, DoMethod);
            DoMethod(dtDoc);
            CallFormList(true,"Documentos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IsDoc = false;
            var myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var types = myAssembly.GetTypes();
            CreateTable();
            var dtExiste = gridUi1.DataSource as DataTable;
            //
            foreach (var t in types)
            {
                if (t.BaseType == null) continue;
                if (t.BaseType.Name.Trim() != "FrmClasse") continue;
                var obj1 = Activator.CreateInstance(t);
                if (((FrmClasse)obj1).Controlacesso)
                {
                    if (dtExiste.HasRows())
                    {
                        var existe = dtExiste.AsEnumerable().Any(x => x.Field<string>("ecran").Trim().Equals(t.Name.Trim()));
                        if (!existe)
                        {
                            NewMethod(obj1);
                        }
                    }
                    else
                    {
                        NewMethod(obj1);
                    }
                }
                ((FrmClasse)obj1).Dispose();
            }
            CallFormList(false,"Formulários");
        }

        private void NewMethod(object obj1)
        {
            var dr = _dtForms.NewRow();
            dr["Ecran"] = ((FrmClasse)obj1).Name.Trim();
            dr["Descricao"] = ((FrmClasse)obj1).label1.Text.Trim();
            dr["Ok"] = false;
            dr["Origem"] = tbSigla.tb1.Text;
            dr["Oristamp"] = Pbl.Stamp(); 
            _dtForms.Rows.Add(dr);
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridUi1, _modulosfrmdoc, tbProcura.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var dres = MsBox.Show("Deseja eliminar o registo?", DResult.YesNo);
            if (dres.DialogResult != DialogResult.Yes) return;
            foreach (DataGridViewRow dr in gridUi1.Rows)
            {
                if (dr == null) continue;
                if (!dr.Cells["ok"].Value.ToBool()) continue;
                var res = SQL.SqlCmd($"delete from Modulosfrmdoc where Modulosfrmdocstamp='{dr.Cells["Modulosfrmdocstamp"].Value.ToString().Trim()}'");
                gridUi1.Rows.Remove(dr);
            }
            Helper.Alert("Processo terminado", Form_Alert.EnmType.Info);
        }

        private void cbDefault1_CheckedChangeds()
        {
            gridUi1.CheckUncheckAll("ok", cbDefault1.cb1.Checked);
        }
    }
}
