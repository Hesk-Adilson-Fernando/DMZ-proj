using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmPlanoaval : Basic.FrmClasse
    {
        public FrmPlanoaval()
        {
            InitializeComponent();
        }
        private Planoaval planoaval;
        private void FrmPlanoaval_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Planoaval";
        }
        public override void DefaultValues()
        {
            planoaval = DoAddline<Planoaval>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(planoaval);
            EF.Save(planoaval);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            planoaval = FillControls(planoaval, dt, i);
        }
    }
}
