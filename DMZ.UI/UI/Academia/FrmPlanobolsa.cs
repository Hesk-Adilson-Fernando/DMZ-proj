using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmPlanobolsa : Basic.FrmClasse
    {
        public FrmPlanobolsa()
        {
            InitializeComponent();
        }

        private void FrmPlanobolsa_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Planobolsa";
        }

        private Planobolsa planobolsa;
        public override void DefaultValues()
        {
            planobolsa = DoAddline<Planobolsa>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(planobolsa);
            EF.Save(planobolsa);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            planobolsa = FillControls(planobolsa, dt, i);
        }
    }
}
