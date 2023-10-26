
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.TM;
using DMZ.UI.UI.FT;
using System;
using System.Data;

namespace DMZ.UI.UI.TM
{
    public partial class FrmCorredor : Basic.FrmClasse
    {
        public FrmCorredor()
        {
            InitializeComponent();
        }
        private Familia _fam;
        public decimal Tipofam { get; set; }
        private void FrmCorredor_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Familia";
            CCondicao = $"Tipofam ={Tipofam}";
        }
        private void BindAutoCarros()
        {
            if (!CLocalStamp.IsNullOrEmpty())
            {
                var str = $@"select Descviatura,Matricula,Familiastamp,Familiacarlstamp,Ststamp from Familiacarl join Familiacar 
                            on Familiacar.Familiacarstamp=Familiacarl.Familiacarstamp
                            where Familiastamp = '{CLocalStamp}' ";
                var dt = SQL.GetGen2DT(str);
                if (dt.HasRows())
                {
                    gridUiAutocarros.SetDataSource(dt);
                }
                tbTotalCarros.Text = $"{dt.TotalRows() + " Autocarro(s)"}";
            }
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
            BindAutoCarros();
        }

        private void gridUiCarreira_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var nome = gridUiCarreira.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (nome.Equals("addcarro"))
            {
                if (Procurou)
                {
                    var Familiacarstamp = gridUiCarreira.CurrentRow.Cells["Familiacarstamp"].Value.ToString();
                    var w = new FrmAddAutocarro
                    {
                        Familiacarstamp = Familiacarstamp,//
                    };
                    w.ShowForm(this);
                    w.gridPanel21.label1.Text = gridUiCarreira.CurrentRow.Cells["descricao"].Value.ToString();
                }
                else
                {
                    MsBox.Show("Deve gravar os dados da turma primeiro!");
                }
            }
        }

        private void gridUiAutocarros_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Helper.ShowForm<FrmVt>(gridUiAutocarros, this, "st", "Ststamp", "origemm");
        }
    }
}
