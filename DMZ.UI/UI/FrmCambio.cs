using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;


namespace DMZ.UI.UI
{
    public partial class FrmCambio : Basic.FrmClasse
    {
        private Cambio _cambio;

        public FrmCambio()
        {
            InitializeComponent();
        }

        private void FrmCambio_Load(object sender, EventArgs e)
        {
            Campo1 = "Data";
            Campo2 = "Moeda";
            Ctabela = "Cambio";
        }
        public override void DefaultValues()
        {
            _cambio = DoAddline<Cambio>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_cambio);
            EF.Save(_cambio);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _cambio = FillControls(_cambio, dt, i);
        }
    }
}
