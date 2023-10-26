using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmLCont : Basic.FrmClasse
    {
        private Lcont _pgc;

        public FrmLCont()
        {
            InitializeComponent();
        }

        private void FrmLCont_Load(object sender, EventArgs e)
        {
            Ctabela = "Lcont";
            Campo1 = "conta";
            Campo2 = "descricao";
        }
        public override void DefaultValues()
        {
            _pgc = DoAddline<Lcont>();
            base.DefaultValues();
        }
        public override void Gravar()
        {
            FillEntity(_pgc);
            SQLExec.Save(_pgc);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _pgc = FillControls(_pgc, dt, i);
        }
    }
}
