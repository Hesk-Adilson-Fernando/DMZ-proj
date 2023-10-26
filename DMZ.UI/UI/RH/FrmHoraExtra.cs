using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI.RH
{
    public partial class FrmHoraExtra : FrmClasse
    {
        private HoraExtra _horaExtra;
        public FrmHoraExtra()
        {
            InitializeComponent();
        }
        private void FrmHoraExtra_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "HoraExtra";
        }
        public override void DefaultValues()
        {
            _horaExtra = DoAddline<HoraExtra>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_horaExtra);
            EF.Save(_horaExtra);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _horaExtra = FillControls(_horaExtra, dt, i);
        }
    }
}
