using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI
{
    public partial class FrmMtr : Basic.FrmClasse
    {
        public FrmMtr()
        {
            InitializeComponent();
        }
        private Ctauxiliar _ctauxiliar;

        public string Desctabela { get; set; }
        public decimal Tabela { get; set; }
        private void FrmMtr_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "ctAuxiliar";
            CCondicao = $"tabela={Tabela}";
            label1.Text = Desctabela;
            if (Tabela == 2)
            {
                tbObs.label1.Text = @"Sigla";
            }

            barraText1.Label1Text = $"Dados de {Desctabela}";
        }
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

        private void tbObs_Load(object sender, EventArgs e)
        {

        }

        int tbos = 0;

        private void calcular()
        {
           // tbObs ob = new tbObs();
           //int ob=
        }
    }
}

