using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmPv : Basic.FrmClasse
    {
        private Pv _pv;

        public FrmPv()
        {
            InitializeComponent();
        }

        private void FrmPv_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "pv";
        }

        public override void DefaultValues()
        {
            _pv = DoAddline<Pv>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_pv);
            EF.Save(_pv);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _pv = FillControls(_pv, dt, i);
        }

    }
}
