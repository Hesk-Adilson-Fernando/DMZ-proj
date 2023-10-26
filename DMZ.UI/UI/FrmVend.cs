using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmVend : Basic.FrmClasse
    {
        public FrmVend()
        {
            InitializeComponent();
        }
        private Vend _vend;
        private void FrmVend_Load(object sender, EventArgs e)
        {
            Campo1 = "no";
            Campo2 = "nome";
            Ctabela = "vend";
        }
        public override void DefaultValues()
        {
            _vend = DoAddline<Vend>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_vend);
            EF.Save(_vend);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _vend = FillControls(_vend, dt, i);
        }
    }
}
