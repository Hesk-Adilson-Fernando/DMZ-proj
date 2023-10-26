using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmMesas : Basic.FrmClasse
    {
        private Mesas _mesas;

        public FrmMesas()
        {
            InitializeComponent();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "mesas";
        }
        public override void DefaultValues()
        {
            _mesas = DoAddline<Mesas>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_mesas);
            EF.Save(_mesas);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _mesas = FillControls(_mesas, dt, i);
        }
    }
}
