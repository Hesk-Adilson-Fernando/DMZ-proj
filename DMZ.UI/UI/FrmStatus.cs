using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI
{
    public partial class FrmStatus : DMZ.UI.Basic.FrmClasse
    {
        public FrmStatus()
        {
            InitializeComponent();
        }
        private Status _stats;
        private void FrmStatus_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Status";
        }
        public override void DefaultValues()
        {
            _stats = DoAddline<Status>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_stats);
            EF.Save(_stats);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _stats = FillControls(_stats, dt, i);
        }
    }
}
