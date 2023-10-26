using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmFing : Basic.FrmClasse
    {
        public FrmFing()
        {
            InitializeComponent();
        }
        private void FrmFg_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Fing";
        }
        private Fing _fing;
        public override void DefaultValues()
        {
            _fing = DoAddline<Fing>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_fing);
            EF.Save(_fing);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _fing = FillControls(_fing, dt, i);
        }
    }
}
