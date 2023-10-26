using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmTirps : FrmClasse
    {
        private Tirps _tirps;

        public FrmTirps()
        {
            InitializeComponent();
        }

        private void FrmTirps_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "descricao"; 
            Ctabela = "Tirps";
        }
        public override void DefaultValues()
        {
            _tirps = DoAddline<Tirps>();
            base.DefaultValues();

        }
        public override void Save()
        {
            FillEntity(_tirps);
            EF.Save(_tirps);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _tirps = FillControls(_tirps, dt, i);
        }

        private void tbNumero_Load(object sender, EventArgs e)
        {

        }

        private void tbNome_Load(object sender, EventArgs e)
        {

        }
    }
}
