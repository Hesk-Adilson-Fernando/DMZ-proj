using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI.RH
{
    public partial class FrmTpgp : FrmClasse
    {
        public FrmTpgp()
        {
            InitializeComponent();
        }
        private Tpgp _tpgp;
        private void FrmTpgp_Load(object sender, EventArgs e)
        {
            Campo1 = "Numdoc";
            Campo2 = "descricao";
            Ctabela = "Tpgp";
        }
        public override void DefaultValues()
        {
            _tpgp = DoAddline<Tpgp>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_tpgp);
            EF.Save(_tpgp);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _tpgp = FillControls(_tpgp, dt, i);
        }
    }
}
