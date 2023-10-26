using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmPeAuxilar : Basic.FrmClasse
    {
        public FrmPeAuxilar()
        {
            InitializeComponent();
        }
        private PeAuxiliar _peAuxiliar;

        public string Desctabela { get;  set; }
        public decimal Tabela { get;  set; }
        private void FrmPeAuxilar_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "PeAuxiliar";
            CCondicao = $"tabela={Tabela}";
            label1.Text = Desctabela;
            if (Tabela==2)
            {
                tbObs.label1.Text = @"Sigla";
            }

            barraText1.Label1Text = $"Dados de {Desctabela}";
        }

        public override void DefaultValues()
        {
            _peAuxiliar = DoAddline<PeAuxiliar>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_peAuxiliar);
            _peAuxiliar.Desctabela = Desctabela;
            _peAuxiliar.Tabela = Tabela;
            EF.Save(_peAuxiliar);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _peAuxiliar = FillControls(_peAuxiliar, dt, i);
        }
    }
}
