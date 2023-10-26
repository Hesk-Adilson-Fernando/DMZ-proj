using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.RH
{
    public partial class FrmTodcpe : Basic.FrmClasse
    {
        public FrmTodcpe()
        {
            InitializeComponent();
        }
        private Tdocpe _tdoc;
        private void FrmTodcpe_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "tdocpe";
        }
        public override void DefaultValues()
        {
            _tdoc = DoAddline<Tdocpe>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_tdoc);
            EF.Save(_tdoc);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _tdoc = FillControls(_tdoc, dt, i);
        }

        private void cbDefault17_Load(object sender, EventArgs e)
        {

        }
    }
}
