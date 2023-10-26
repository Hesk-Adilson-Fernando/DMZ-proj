using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmMvte : Basic.FrmClasse
    {
        public FrmMvte()
        {
            InitializeComponent();
        }
        public Mvt Mvt;
        private Formasp _fp;

        public string Tipo { get;  set; }

        private void FrmMvte_Load(object sender, EventArgs e)
        {
            Campo1 = "codlocal";
            Campo2 = "local";
            Ctabela = "Mvt";
            CCondicao = $"Origem = '{Tipo}'";
            Contas.ReturnDt = true;
            Contas.Condicao = "";
        }

        public override void DefaultValues()
        {
            Mvt = DoAddline<Mvt>();
            if (Tipo=="MVTE")
            {
                Mvt.Origem = Tipo;
                Mvt.Tipomov = 1;
            }
            else
            {
                Mvt.Origem = Tipo;
                Mvt.Tipomov = 2;
            }
            Mvt.Formaspstamp = null;
          
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(Mvt);
            Mvt.Formaspstamp = _fp.Formaspstamp;
            EF.Save(Mvt);
        }

        public override bool BeforeSave()
        {
            _fp = new Formasp {Formaspstamp = Pbl.Stamp(), Banco = Banco.tb1.Text, Pgfstamp = ""};

            return EF.Save(Mvt).ret==1;
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            Mvt = FillControls(Mvt, dt, i);
        }

        private void FormaP_RefreshControls()
        {
            if (!FormaP.Text3.Trim().Equals("1"))
            {
                tbTitulo.tb1.ReadOnly = true;
                Banco.button1.Enabled = false;
            }
            else
            {
                tbTitulo.tb1.ReadOnly = false;
                Banco.button1.Enabled = true;
            }

        }
        private void Contas_RefreshControls()
        {
            tbMoeda.tb1.Text = Contas.Text2;
            Mvt.Codlocal = Contas.TmpFound.Rows[0]["codigo"].ToString().ToDecimal();
        }
    }
}
