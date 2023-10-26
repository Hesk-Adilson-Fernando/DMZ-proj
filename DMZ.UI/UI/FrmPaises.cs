using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmPaises : Basic.FrmClasse
    {
        public FrmPaises()
        {
            InitializeComponent();
        }
        private Paises _paises;
        private void FrmPaises_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "paises";
        }

        public override void DefaultValues()
        {
            _paises = DoAddline<Paises>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_paises);
            EF.Save(_paises);
        }
        //public override void Actualizar()
        //{
        //    AutomaticEntityFill(_paises);
        //    SQLExec.UpdateEntity(_paises);
        //}
        public override void PreencheCampos(DataTable dt, int i)
        {
            _paises = FillControls(_paises, dt, i);
        }
    }
}
