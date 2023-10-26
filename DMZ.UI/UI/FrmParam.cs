using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmParam : FrmClasse
    {
        private Param _param;
        private DataTable dtUsr { get; set; }

        public FrmParam()
        {
            InitializeComponent();
        }

        private void FrmParam_Load(object sender, EventArgs e)
        {
            Campo1 = "Codprod";
            Campo2 = "CodprodMascra";
            Ctabela = "param";
            var dt = Pbl.Param.ToDataTable();// SQL.GetGen2DT("select * from param");
            PreencheCampos(dt,0);
            Procurou = true;
            var f = MdiParent;
            if (MdiParent !=null)
            {
                if (f.Name== "MdiCont")
                {
                    tabControl1.Controls.Remove(tabPageGestao);
                    tabControl1.Controls.Remove(tabPagePOS);
                }
            }
            else
            {
                //tabControl1.Controls.Remove(tabPageContabil);  
                tabControl1.Controls.Remove(tabPageGestao);
            }
            
        }

        public void RemoveTabs()
        {
            tabControl1.Controls.Remove(tabPageContabil);
            tabControl1.Controls.Remove(tabPageProjecto);//tabPageEmailConfig
            tabControl1.Controls.Remove(tabPageEmailConfig);//
        }

        public override void DefaultValues()
        {
            _param = DoAddline<Param>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_param);
            EF.Save(_param);
            Pbl.Param = _param;
        }
        public override void AfterSave()
        {
            if (tbAnoref.tb1.Text.ToDecimal() != Pbl.SqlDate.Year) 
            {
                Pbl.SqlDate = SQL.CurrentData();
                ((DemoMdi)MdiParent).btnAnoGest.button3.Text = Pbl.SqlDate.Year.ToString();
            }
            ((DemoMdi)MdiParent).btnAnoCT.button3.Text = Pbl.AnoContabil().ToString();
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _param = FillControls(_param, dt, i);
        }

        private void tabPageGestao_Click(object sender, EventArgs e)
        {

        }
        private DataTable dt;
        private DataTable dtcc;
        private DataTable _dtconta;

        private void gridImpr_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridImpr.CurrentRow == null) return;
            //var qry = "select Ststamp,Referenc,Descricao from st ";
            var name = gridImpr.CurrentCell.OwningColumn.Name.ToLower();
            //DataRow = ((DataRowView)gridImpr.CurrentRow.DataBoundItem).Row;
            
            if (name.Equals("pos"))
            {
                Helper.SetBinds(e.Control,dt);
            }
            else if (name.Equals("normal1"))
            {
                Helper.SetBinds(e.Control,dt);
            }
            else if (name.Equals("normal2"))
            {
                Helper.SetBinds(e.Control,dt);
            }
            else if (name.Equals("ccusto"))
            {
                var qry = "select codccu, descricao from ccu";
                dtcc = Helper.SetBinds(e.Control, "descricao", qry);
            }
        }

        private void gridImpr_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var nome = gridImpr.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("ccusto")) ;
            var valor = gridImpr.CurrentCell.Value.ToString().Trim();
            if (dtcc == null) return;
            var dr = dtcc.AsEnumerable().FirstOrDefault(s => s.Field<string>("descricao").Trim().Equals(valor));
            if (dr == null) return;
            if (gridImpr.CurrentRow != null)
                gridImpr.CurrentRow.Cells["Codccu"].Value = dr[0];
        }

        private void tbDefault14_Load(object sender, EventArgs e)
        {

        }

        public DataTable dtTipo { get; set; }
        private void gridUi2_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi2.CurrentRow == null) return;
            var name = gridUi2.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("usuario"))
            {
                dtUsr=Helper.SetBinds(e.Control,"nome","select nome,Email,Usrstamp from usr ");
            }
            else if (name.Equals("tipodes"))
            {
                 dtTipo = Helper.SetBinds(e.Control, "Descricao", "select Codigo,Descricao  from Auxiliar where Tabela=68");
            }
        }

        private void gridUi2_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var nome = gridUi2.CurrentCell.OwningColumn.Name.ToLower();
            if (gridUi2.CurrentRow == null) return;
            var valor = gridUi2.CurrentCell.Value.ToString().Trim();
            if (nome.Equals("usuario"))
            {
                if (dtUsr == null) return;
                var dr = dtUsr.AsEnumerable().FirstOrDefault(s => s.Field<string>("nome").Trim().Equals(valor));
                if (dr == null) return;
                gridUi2.CurrentRow.Cells["Email"].Value = dr["Email"];
                gridUi2.CurrentRow.Cells["Usrstamp"].Value = dr["Usrstamp"];
            }
            if (nome.Equals("tipodes"))
            {
                if (dtTipo == null) return;
                var dr = dtTipo.AsEnumerable().FirstOrDefault(s => s.Field<string>("Descricao").Trim().Equals(valor));
                if (dr == null) return;
                gridUi2.CurrentRow.Cells["codtipo"].Value = dr["Codigo"];
            }
        }

        private DataTable dtTipo2 { get; set; }
        private void gridPreco_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            var name = gridPreco.CurrentCell.OwningColumn.Name;
            if (name.ToLower().Equals("tipo"))
            {
                dtTipo2=Helper.SetBinds(e.Control, "descricao", "select Codigo,Descricao  from ctauxiliar where Tabela=1");
            }
            var lista = new List<Ec>{new Ec{Conta=true,Nome="ClnConta"},new Ec{Conta=false,Nome="descricao"}};
            _dtconta = Ct.EditControl(gridPreco.CurrentCell, e,lista);
        }

        private void gridPreco_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var name = gridPreco.CurrentCell.OwningColumn.Name.ToLower();
            if (gridPreco.CurrentRow == null) return;
            var valor = gridPreco.CurrentCell.Value.ToString().Trim();
            if (name.Equals("tipo"))
            {
                if (dtTipo2 == null) return;
                var dr = dtTipo2.AsEnumerable().FirstOrDefault(s => s.Field<string>("Descricao").Trim().Equals(valor));
                if (dr == null) return;
                gridPreco.CurrentRow.Cells["codtipo2"].Value = dr["Codigo"];
            }
            Ct.CellEndEdit(gridPreco, _dtconta,new List<string>{"descricao","clnconta"});

        }


    }
}
