using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Generic;
using DMZ.UI.TM;

namespace DMZ.UI.UI
{
    public partial class FrmFamilia : Basic.FrmClasse
    {
        public FrmFamilia()
        {
            InitializeComponent();
        }
        private Familia _fam;
        public decimal Tipofam { get; set; }
        private void FrmFamilia_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Familia";
            gridUI1.Codigo = "Codigo";
            CCondicao = $"Tipofam ={Tipofam}";
            gridUI1.AutoIncrimento = true;

        }
        public override void DefaultValues()
        {
            _fam = DoAddline<Familia>();
            _fam.Tipofam = Tipofam;
            base.DefaultValues();

        }
        public override void Save()
        {
            FillEntity(_fam);
            EF.Save(_fam);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _fam = FillControls(_fam, dt, i);
            gridUI1.Condicao = $"Familiastamp='{CLocalStamp}'";
        }

        private void gridPanel21_CallForm()
        {
            //var existe = SQLExec.CheckExist($"select Familiastamp from Familia where Familiastamp='{CLocalStamp.Trim()}'");

            //if (existe)
            //{
            //    var subf = new FrmSubFam
            //    {
            //        MdiParent = MdiParent,
            //        CodFamilia = tbCodigo.tB1.Text.ToDecimal(),
            //        Familiastamp = CLocalStamp

            //    };
            //    if (!string.IsNullOrEmpty(tbDescricao.tB1.Text))
            //    {
            //        subf.barraText1.Label1Text = $"Família de {tbDescricao.tB1.Text.Trim()}";

            //    }
            //    subf.ShowForm(this);
            //}
            //else
            //{
            //    MsBox.Show("Deve gravar a familía primeiro");
            //}
        }

        private void gridUI1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridUI1.CurrentCell.OwningColumn.Name.Equals("btnProc")) return;
            var opf = new OpenFileDialog
            {
                // chose the images type
                Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"
            };

            if (opf.ShowDialog() != DialogResult.OK) return;
            // get the image returned by OpenFileDialog                   
            if (gridUI1.CurrentRow != null)
                gridUI1.CurrentRow.Cells["Imagem"].Value = Image.FromFile(opf.FileName);
        }

        private void gridUI1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUI1.CurrentCell.OwningColumn.Name.Trim().ToLower().Equals("btnproc")) return;
            var validClick = e.RowIndex != -1 && e.ColumnIndex != -1; //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;
            // Check to make sure the cell clicked is the cell containing the combobox 
            if (!(datagridview?.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) || !validClick) return;
            datagridview.BeginEdit(true);
            // ((TextBox)datagridview.EditingControl). = true;
        }

        private bool gridPanel21_BeforeAddLineEvent()
        {
            bool ret;
            var val = SQL.CheckExist($"select Familiastamp from Familia where Familiastamp='{CLocalStamp}'");
            if (!val)
            {
                MsBox.Show("Deve gravar a familia primeiro!..");
                ret = true;
            }
            else
            {
                ret = false;
            }
            return ret;
        }

        private void gridUiCarreira_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
