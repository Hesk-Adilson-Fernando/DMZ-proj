using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmCpoc : Basic.FrmClasse
    {
        private Cpoc _cpoc;
        private DataTable _dtconta;

        public FrmCpoc()
        {
            InitializeComponent();
        }

        private void FrmCpoc_Load(object sender, EventArgs e)
        {
            Campo1 = "Codcpoc";
            Campo2 = "Descricao"; 
            Ctabela = "cpoc";
        }
        public override void DefaultValues()
        {
            _cpoc = DoAddline<Cpoc>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_cpoc);
            EF.Save(_cpoc);
        }
        public override bool BeforeSave()
        {
            var dtvenda = gridUi1.DataSource as DataTable;
            if (dtvenda?.Rows.Count==0)
            {
                MsBox.Show(Messagem.ParteInicial() + "A tabela de contas de venda não pode estar vazio!");
                return false; 
            }
            var dtcompra = gridUi2.DataSource as DataTable;
            if (dtcompra?.Rows.Count != 0) return base.BeforeSave();
            MsBox.Show(Messagem.ParteInicial() + "A tabela de contas de compra não pode estar vazio!");
            return false;
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _cpoc = FillControls(_cpoc, dt, i);
        }

        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi1.CurrentRow != null)
            {
                ProcessaIva(e,gridUi1);
                var lista = new List<Ec>{new Ec{Conta=true,Nome="ValVenda"},new Ec{Conta=true,Nome="iva"},new Ec{Conta=true,Nome="Desconto"},new Ec{Conta=true,Nome="Descontofin"}};
                _dtconta = Ct.EditControl(gridUi1.CurrentCell, e,lista);
            }

        }

        private void ProcessaIva(DataGridViewEditingControlShowingEventArgs e,GridUi gridUi1)
        {

                var name = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
                if (name.Equals("tabiva") || name.Equals("tabivax") )
                {
                    DtIva=Helper.IvaSetting("Codigo",e.Control);
                }
                else if (name.Equals("txiva") || name.Equals("txivax"))
                {
                    DtIva=Helper.IvaSetting("Descricao",e.Control);
                }
                else
                {
                    DtIva = null;
                    //var autoText = e.Control as TextBox;
                    //if (autoText != null) 
                    //    autoText.AutoCompleteCustomSource = null;
                }
        }
        public DataTable DtIva { get; set; }
        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SetEndEdit(gridUi1);
        }

        private void SetEndEdit(DataGridView gridUi)
        {
            var nome = gridUi.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("tabiva") || nome.Equals("tabivax"))
            {
                SetTabIva("codigo",gridUi);
            }
            if (nome.Equals("txiva")|| nome.Equals("txivax"))
            {
                SetTabIva("descricao",gridUi);
            }
        }

        private void SetTabIva(string codigo,DataGridView grid)
        {
            if (grid.CurrentCell?.Value == null) return;
            var valor = grid.CurrentCell.Value.ToString().Trim();
            string campo;
            if (DtIva != null)
            {
                DataRow dr;
                switch (codigo)
                {
                    case "descricao":
                        campo = grid.Name.ToLower().Trim().Equals("gridui1") ? "tabiva" : "tabivax";
                        dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<string>(codigo).Equals(valor));
                        if (dr == null) return;
                        if (grid.CurrentRow != null) 
                            grid.CurrentRow.Cells[$"{campo}"].Value = dr[0].ToString();
                        break;
                    case "codigo":
                        campo = grid.Name.ToLower().Trim().Equals("gridui1") ? "txiva" : "txivax";
                        dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<decimal>(codigo).ToDecimal().Equals(valor.ToDecimal()));
                        if (dr == null) return;
                        if (grid.CurrentRow != null) 
                            grid.CurrentRow.Cells[$"{campo}"].Value = dr[1].ToString();
                        break;
                }
            }
            grid.Update();
        }

        private void gridUi2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi2.CurrentRow == null) return;
            ProcessaIva(e,gridUi2);
            var lista = new List<Ec>{new Ec{Conta=true,Nome="Valcompra"},new Ec{Conta=true,Nome="ivacompra"},new Ec{Conta=true,Nome= "descontocompra" },new Ec{Conta=true,Nome= "Descontofincompra" } };
            _dtconta = Ct.EditControl(gridUi2.CurrentCell, e,lista);
        }

        private void gridUi2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SetEndEdit(gridUi2);
        }
    }
}
