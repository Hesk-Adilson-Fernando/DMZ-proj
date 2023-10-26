using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI
{
    public partial class FrmAuxilar : Basic.FrmClasse
    {
        public FrmAuxilar()
        {
            InitializeComponent();
        }
        private Auxiliar _auxiliar;

        public string Desctabela { get;  set; }
        public decimal Tabela { get;  set; }
        public bool Height2 { get; set; }
        private void FrmAuxilar_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Auxiliar";
            CCondicao = $"tabela={Tabela}";
            label1.Text = Desctabela;
            if (Tabela==2)
            {
                tbObs.label1.Text = "Sigla";
            }

            barraText1.Label1Text = $"Dados de {Desctabela}";
            if (!Height2)
            {
                Height = 290;
            }
            else
            {
                Height = 462;
            }
            
        }
        public override void DefaultValues()
        {
            _auxiliar = DoAddline<Auxiliar>();
            base.DefaultValues();
        }
        public override void Gravar()
        {
            FillEntity(_auxiliar);
            _auxiliar.Desctabela = Desctabela;
            _auxiliar.Tabela = Tabela;
            SQLExec.Save(_auxiliar);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _auxiliar = FillControls(_auxiliar, dt, i);
        }
    }
}
