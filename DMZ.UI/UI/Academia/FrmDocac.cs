using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmDocac : Basic.FrmClasse
    {
        public FrmDocac()
        {
            InitializeComponent();
        }

        private void FrmDocac_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Docac";
        }
        private Docac docac;
        public override void DefaultValues()
        {
            docac = DoAddline<Docac>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(docac);
            EF.Save(docac);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            docac = FillControls(docac, dt, i);
        }
    }
}
