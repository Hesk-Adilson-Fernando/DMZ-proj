using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmTdi : FrmClasse
    {
        private Tdi _tdi;

        public FrmTdi()
        {
            InitializeComponent();
        }

        private void FrmTdi_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "tdi";

            //gridPanel2.Callform += gridPanel2_CallForm;
        }
        public override void AfterSave()
        {
            if (cbPadrao.cb1.Checked)
            {
                SQL.SqlCmd($"update Tdi set Defa=0 where Tdistamp<>'{CLocalStamp.Trim()}'");
            }
            base.AfterSave();
        }
        public override void DefaultValues()
        {
            _tdi = DoAddline<Tdi>();
            base.DefaultValues();
            //dmzOptionGroup1.RefreshControl();
        }
        public override void Save()
        {
            FillEntity(_tdi);
            //_tdi.Noentid = !cbDefault4.cb1.Checked;
            EF.Save(_tdi);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _tdi = FillControls(_tdi, dt, i);
        }
        private void gridPanel2_CallForm()
        {
            var f = new FrmAddlines("Módulos Disponíveis", "Select Descricao,obs, OK = CAST(0 as bit) from modulos") { PControl = ReceiveData };
            f.ShowForm(this);

        }
        public void ReceiveData(DataTable dt)
        {
            Helper.UpdateGridModulos(gridUi1,"tdistamp",dt,CLocalStamp);
            //if (!(dt?.Rows.Count > 0)) return;
            //var tab = gridUi1.DataSource as DataTable;
            //foreach (var r in dt.AsEnumerable())
            //{
            //    if (r == null) continue;
            //    if (tab == null) continue;
            //    var dr = tab.NewRow().Inicialize();
            //    dr["codigo"] = r["descricao"].ToString();
            //    dr["descricao"] = r["obs"].ToString();
            //    dr["tdistamp"] = CLocalStamp;
            //    tab.Rows.Add(dr);
            //}
            //gridUi1.DataSource = null;
            //gridUi1.DataSource = tab;
            //gridUi1.Update();
        }

        private void gridUi1_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            var name = gridUi1.CurrentCell.OwningColumn.Name;
            if (name.Equals("obs"))
            {
                Dtmod=Helper.SetBinds(e.Control, "obs", "select Descricao,Obs from Modulos ");
            }
            if (name.Equals("descricao"))
            {
                Dtmod=Helper.SetBinds(e.Control, "descricao", "select Descricao,Obs from Modulos ");
            }
            //if (name.Equals("Tipo"))
            //{
            //    Helper.SetBinds(e.Control, "Descricao", "select Descricao from PeAuxiliar where Tabela=18");
            //}
        }

        public DataTable Dtmod { get; set; }

        private void gridUi1_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            switch (nome)
            {
                case "descricao":
                    CallUpdRow("descricao");
                    break;
                case "obs":
                    CallUpdRow("obs");
                    break;
            }
        }

        private void CallUpdRow(string campo)
        {
            if (gridUi1.CurrentCell == null) return;
            if (gridUi1.CurrentCell.Value == null) return;
            var valor = gridUi1.CurrentCell.Value.ToString().Trim();
            if (Dtmod.HasRows())
            {
                var dr = Dtmod.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
                if (dr != null)
                {
                    if (campo.Equals("obs"))
                    {
                        gridUi1.CurrentRow.Cells["descricao"].Value= dr["descricao"].ToString(); 
                    }
                    if (campo.Equals("descricao"))
                    {
                        gridUi1.CurrentRow.Cells["Codigo"].Value = dr["obs"].ToString();
                    }
                }
            }
        }
    }
}
