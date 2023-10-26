using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI.RH
{
    public partial class FrmFalta : FrmClasse
    {
        private Falta _falta;
        public FrmFalta()
        {
            InitializeComponent();
        }

        private void FrmFalta_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Falta";
        }
        public override void DefaultValues()
        {
            _falta = DoAddline<Falta>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_falta);
            EF.Save(_falta);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _falta = FillControls(_falta, dt, i);
        }
    }
}
