using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmMeses : Basic.FrmClasse
    {
        private Meses _mes;
        public FrmMeses()
        {
            InitializeComponent();
        }

        private void FrmMeses_Load(object sender, EventArgs e)
        {
            Ctabela = "Meses";
            Campo1 = "codigo";
            Campo2 = "descricao";
        }

        public override void DefaultValues()
        {
            _mes = DoAddline<Meses>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_mes);
            EF.Save(_mes);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _mes = FillControls(_mes, dt, i);
        }
    }
}
