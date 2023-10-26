using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmTiporesult : Basic.FrmClasse
    {
        public FrmTiporesult()
        {
            InitializeComponent();
        }
        private Tiporesult tiporesult;
        private void FrmTiporesult_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Tiporesult";
        }
        public override void DefaultValues()
        {
            tiporesult = DoAddline<Tiporesult>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(tiporesult);
            EF.Save(tiporesult);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            tiporesult = FillControls(tiporesult, dt, i);
        }
    }
}
