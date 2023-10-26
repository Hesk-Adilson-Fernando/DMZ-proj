using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;


namespace DMZ.UI.UI
{
    public partial class FrmCCusto : FrmClasse
    {
        public FrmCCusto()
        {
           InitializeComponent();
        }
        private CCu _ccu;
        private Empresa emp;
        public bool Escola { get; set; }
        private void FrmCCusto_Load(object sender, EventArgs e)
        {
            Campo1 = "CodCcu";
            Campo2 = "descricao";
            Ctabela = "ccu";
            emp = SQL.GetRowToEnt<Empresa>();
            if (Escola)
            {
                tabControl1.TabPages.Remove(Inicio);
                tabControl1.TabPages.Remove(tabPageCaixa);
                tabControl1.TabPages.Remove(tabPageTerminais);
                tabControl1.TabPages.Remove(tabPageNumeros);
            }
        }
        public override void DefaultValues()
        {            
            _ccu = DoAddline<CCu>();
            _ccu.Empresastamp = emp.Empresastamp;
            _ccu.Nome = emp.Nome;
            Status.SetStatus();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_ccu);
            EF.Save(_ccu);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _ccu = FillControls(_ccu, dt, i);
        }

        public bool GridCaixa { get; set; }

        private void gridUICaixa_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUICaixa.CurrentRow == null) return;
            string qry;
            if (gridUICaixa.CurrentCell.OwningColumn.Name.Trim() == "conta")
            {
                var select = "codigo,LTRIM(RTRIM(sigla)) + ' '+ LTRIM(RTRIM(convert(varchar(40),numero)))+ ' '+moeda as contas,Contasstamp,descricao,Cxmn";
                qry = $" select {select} from contas ";
                DtConta = Helper.SetBinds(e.Control, "contas", qry);
            }
        }

        public DataTable DtConta { get; set; }

        private void gridUICaixa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUICaixa.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("conta")) return;
            if (gridUICaixa.CurrentCell == null) return;

            var lista = new List<Parametros>
            {
                new Parametros {Param1 = "Codtz", Param2 = "codigo"},
                new Parametros {Param1 = "DescPOS", Param2 = "descricao"},
                new Parametros {Param1 = "Contasstamp", Param2 = "Contasstamp"},//Cxmn
                new Parametros {Param1 = "Cx", Param2 = "Cxmn"},//Cxmn
            };
            Helper.GridCellEndEdit(gridUICaixa, DtConta,lista,"contas");
        }

        private void gridUIArm_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUIArm.CurrentRow == null) return;
            if (gridUIArm.CurrentCell.OwningColumn.Name.Trim() != "descricao") return;
            var dataPropertyName = gridUIArm.CurrentCell.OwningColumn.DataPropertyName;
            DtArm = Helper.SetBinds(e.Control, dataPropertyName, " select Codigo,Descricao,Armazemstamp from Armazem ");
        }

        public DataTable DtArm { get; set; }

        private void gridUIArm_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUIArm.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("descricao")) return;
            var lista = new List<Parametros> {
                new Parametros { Param1 = "Armazemstamp", Param2 = "Armazemstamp" },
                new Parametros { Param1 = "codigo", Param2 = "codigo" } };
            Helper.GridCellEndEdit(gridUIArm, DtArm,lista,  "Descricao"); //
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            MsBox.Show("Parametros não definidos");
        }

        private void tbDefault11_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbCell.tb1.Text=emp.Cell;
            tbMorada.tb1.Text=emp.Morada;
            tbNuit.tb1.Text = emp.Nuit.ToString();
            tbEmail.tb1.Text = emp.Email;
        }
    }
}
