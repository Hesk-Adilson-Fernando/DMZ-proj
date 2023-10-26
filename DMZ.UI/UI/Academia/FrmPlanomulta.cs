using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmPlanomulta : Basic.FrmClasse
    {
        public FrmPlanomulta()
        {
            InitializeComponent();
        }

        private void FrmPlanomulta_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Planomulta";
        }
        private Planomulta planomulta;
        public override void DefaultValues()
        {
            planomulta = DoAddline<Planomulta>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(planomulta);
            EF.Save(planomulta);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            planomulta = FillControls(planomulta, dt, i);
        }
    }
}
