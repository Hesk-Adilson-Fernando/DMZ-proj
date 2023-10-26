using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmDiario : Basic.FrmClasse
    {
        private Diario _diario;

        public FrmDiario()
        {
            InitializeComponent();
        }

        private void FrmDiario_Load(object sender, EventArgs e)
        {
            Ctabela = "Diario";
            Campo1 = "dino";
            Campo2 = "descricao";
            CCondicao = "diano =(select ano from param)";

        }

        public override void DefaultValues()
        {
            _diario = DoAddline<Diario>();
            tbAno.tb1.Text = Pbl.AnoContabil().ToString();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_diario);
            EF.Save(_diario);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _diario = FillControls(_diario, dt, i);
        }

        private void GridDocs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colName = GridDocs.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (colName.Equals("descricao"))
            {
                var qry = "select docno,docnome from dc";
                Dtdoc = Helper.SetBinds(e.Control, "docnome", qry);
            }
            else if (colName.Equals("codigo"))
            {
                var qry = "select docno,docnome from dc";
                Dtdoc = Helper.SetBinds(e.Control, "docno", qry);
            }
            else
            {
                Dtdoc = null;
                var autoText = e.Control as TextBox;
                autoText.AutoCompleteCustomSource = null;
            }

        }
        public DataTable Dtdoc { get; set; }
        private void GridDocs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = GridDocs.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetDoc("docnome");
            }
            if (nome.Equals("docno"))
            {
                SetDoc("docno");
            }
        }

        private void SetDoc(string p0)
        {
            if (GridDocs.CurrentCell?.Value == null) return;
            var valor = GridDocs.CurrentCell.Value.ToString().Trim();
            var dr = Dtdoc.AsEnumerable().FirstOrDefault(s => s.Field<string>(p0.Trim()).Trim().Equals(valor));
            if (dr == null) return;
            switch (p0)
            {
                case "docnome":
                    if (GridDocs.CurrentRow != null) 
                        GridDocs.CurrentRow.Cells["docno"].Value = dr[0].ToString();
                    break;
                default:
                    if (GridDocs.CurrentRow != null) 
                        GridDocs.CurrentRow.Cells["descricao"].Value = dr[1].ToString();
                    break;
            }

            GridDocs.Update();
        }

        private void Extrato_Click(object sender, EventArgs e)
        {
                var p = new FrmExtDiario();
                //p.Condicao=$"ano={Pbl.AnoContabil()}";
                p.ShowForm(this);
        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            Menu.ShowMenuStrip(btnMenuLateral);
        }
    }
}
