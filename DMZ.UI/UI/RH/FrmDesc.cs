using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI.RH
{
    public partial class FrmDesc : FrmClasse
    {
        private Desconto _desconto;
        public FrmDesc()
        {
            InitializeComponent();
        }

        private void FrmDesc_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Desconto";
        }
        public override void DefaultValues()
        {
            _desconto = DoAddline<Desconto>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_desconto);
            EF.Save(_desconto);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _desconto = FillControls(_desconto, dt, i);
        }
    }
}
