using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI
{
    public partial class FrmBanco : Basic.FrmClasse
    {
        public FrmBanco()
        {
            InitializeComponent();
        }
        private Banco _stats;
        private void FrmBanco_Load(object sender, EventArgs e)
        {
            Campo1 = "sigla";
            Campo2 = "nome";
            Ctabela = "Banco";
        }
        public override void DefaultValues()
        {
            _stats = DoAddline<Banco>();
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
