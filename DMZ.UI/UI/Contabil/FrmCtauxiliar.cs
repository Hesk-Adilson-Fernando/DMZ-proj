using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmCtauxiliar : Basic.FrmClasse
    {
        public FrmCtauxiliar()
        {
            InitializeComponent();
        }
        private Ctauxiliar _ctauxiliar;

        public string Desctabela { get;  set; }
        public decimal Tabela { get;  set; }
        private void FrmCtauxiliar_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "ctAuxiliar";
            CCondicao = $"tabela={Tabela}";
            label1.Text = Desctabela;
            if (Tabela==2)
            {
                tbObs.label1.Text = @"Sigla";
            }

            barraText1.Label1Text = $"Dados de {Desctabela}";
            Height = !Height2 ? 290 : 462;
        }

        public bool Height2 { get; set; }

        public override void DefaultValues()
        {
            _ctauxiliar = DoAddline<Ctauxiliar>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_ctauxiliar);
            _ctauxiliar.Desctabela = Desctabela;
            _ctauxiliar.Tabela = Tabela;
            EF.Save(_ctauxiliar);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _ctauxiliar = FillControls(_ctauxiliar, dt, i);
        }
    }
}
