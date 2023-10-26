using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmAcessos : FrmClasse2
    {
        public FrmAcessos(FrmUsr _fusr)
        {
            InitializeComponent();
            fusr = _fusr;  
        }

        private FrmUsr fusr;
        private void FrmAcessos_Load(object sender, EventArgs e)
        {
            gridUi1.SetDataSource(DtAcessos);
        }
        public string Modulo { get; set; }
        public UsrModulo UsrModulo { get; set; }
        public string Usrstamp { get; set; }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            var dt2 = SQL.GetGen2DT($@"select Modulosfrmdoc.Descricao,Ecran,Origem,oristamp from Modulos join Modulosfrmdoc on 
                                Modulos.Modulosstamp=Modulosfrmdoc.Modulosstamp where Modulos.Descricao='GES'
								and Ecran not in (select ecran from Usracessos where Usrstamp='{Usrstamp}')");
            if (!(dt2?.Rows.Count > 0)) return;
            //Helper.DoProgressProcess(dt2, FillData);

            foreach (var row in dt2.AsEnumerable())
            {
                if (row != null)
                {
                    var dr = DtAcessos.NewRow().Inicialize();
                    dr["Usracessostamp"] = Pbl.Stamp();
                    dr["oristamp"] = row["oristamp"];
                    dr["Usrmodulostamp"] = Usrmodulostamp;
                    dr["Usrstamp"] = Usrstamp;
                    dr["ecran"] = row["Ecran"];
                    dr["Descricao"] = row["Descricao"];
                    dr["Origem"] = row["Origem"];
                    DtAcessos.Rows.Add(dr);
                }
            }
            gridUi1.Invokex(x => x.SetDataSource(DtAcessos));
        }

        private void FillData(DataRow row, bool fim)
        {
            if (row !=null)
            {
                var dr = DtAcessos.NewRow().Inicialize();
                dr["Usracessostamp"] = Pbl.Stamp();
                dr["oristamp"] = row["oristamp"];
                dr["Usrmodulostamp"] = Usrmodulostamp;
                dr["Usrstamp"] = Usrstamp;
                dr["ecran"] = row["Ecran"];
                dr["Descricao"] = row["Descricao"];
                dr["Origem"] = row["Origem"];
                DtAcessos.Rows.Add(dr);
            }
            if (fim)
            {
                gridUi1.Invokex(x => x.SetDataSource(DtAcessos));
               // gridUi1.Invokex(x => x.Update());
                //if (fusr.DtUsracessos.Rows.Count>0)
                //{
                //    lbLTotalRegistos.Text = fusr.Invokex(x=>x.DtUsracessos.Rows.Count.ToString());  
                //}
            }
        }

        public string Usrmodulostamp { get; set; }
        public DataTable DtAcessos { get; internal set; }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            gridUi1.Update();
            fusr.DtUsracessos = DtAcessos;
            Close();
        }

        private void cbDefault1_CheckedChangeds()
        {
            UpdCln(cbDefault1.cb1.Checked, "ver");
        }

        private void UpdCln(bool cb1Checked, string s)
        {
            foreach (DataGridViewRow r in gridUi1.Rows)
            {
                r.Cells[s].Value = cb1Checked;
            }
        }

        private void cbDefault2_CheckedChangeds()
        {
            UpdCln(cbDefault2.cb1.Checked, "Intro");
        }

        private void cbDefault3_CheckedChangeds()
        {
            UpdCln(cbDefault3.cb1.Checked, "Alterar");
        }

        private void cbDefault4_CheckedChangeds()
        {
            UpdCln(cbDefault4.cb1.Checked, "Apagar");
        }

        private void cbDefault5_CheckedChangeds()
        {
            UpdCln(cbDefault5.cb1.Checked, "Anular");
        }

        private void cbDefault6_CheckedChangeds()
        {
            UpdCln(cbDefault6.cb1.Checked, "Imprimir");
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridUi1, fusr.DtUsracessos, tbProcura.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dres = MsBox.Show("Deseja eliminar o(s) registo(s) selecionado(s)?", DResult.YesNo);
            if (dres.DialogResult != DialogResult.Yes) return;
            gridUi1.Update();
            if (!cbDefault7.cb1.Checked)
            {
                foreach (DataGridViewRow dr in gridUi1.Rows)
                {
                    if (dr == null) continue;
                    if (!dr.Cells["checkBoxColumn"].Value.ToBool()) continue;
                    var res = SQL.SqlCmd($"delete from Usracessos where Usracessostamp='{dr.Cells["Usracessostamp"].Value.ToString().Trim()}'");
                    if (res>0)
                    {
                        gridUi1.Rows.Remove(dr);
                    }
                }
                Helper.Alert("Processo terminado", Form_Alert.EnmType.Success);
            }
            else
            {
                var res = SQL.SqlCmd($"delete from Usracessos where Usrstamp='{Usrstamp.Trim()}'");
                if (res>0)
                {
                    var dt = gridUi1.GetBindedTable();
                    if (dt.Rows.Count>0)
                    {
                        dt.Rows.Clear();
                        gridUi1.SetDataSource(dt);
                    }
                    Helper.Alert("Processo terminado", Form_Alert.EnmType.Success);
                }
            }
        }

        private void cbDefault7_CheckedChangeds()
        {
            gridUi1.CheckUncheckAll("checkBoxColumn", cbDefault7.cb1.Checked);
        }
    }
}
