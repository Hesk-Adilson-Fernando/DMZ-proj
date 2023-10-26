using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmLaranja : Basic.FrmClasse
    {
        private Laranja _cl;

        public FrmLaranja()
        {
            InitializeComponent();
        }

        private void FrmLaranja_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao"; 
            Ctabela = "Laranja";  
        }
        public override void DefaultValues()
        {
            _cl = DoAddline<Laranja>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_cl);
            EF.Save(_cl);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _cl = FillControls(_cl, dt, i);
        }

    }
}
