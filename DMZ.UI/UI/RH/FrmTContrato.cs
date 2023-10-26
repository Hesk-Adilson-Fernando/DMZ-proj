using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.RH
{
    public partial class FrmTContrato : Basic.FrmClasse
    {
        public FrmTContrato()
        {
            InitializeComponent();
        }
        private TContrato contrato;
        private void FrmTContrato_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "TContrato";
        }

        public override void DefaultValues()
        {
            contrato = DoAddline<TContrato>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(contrato);
            EF.Save(contrato);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            contrato = FillControls(contrato, dt, i);
        }
    }
}
