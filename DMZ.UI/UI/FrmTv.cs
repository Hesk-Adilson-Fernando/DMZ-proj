using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmTv : Basic.FrmClasse
    {
        public FrmTv()
        {
            InitializeComponent();
        }
        private Ccutv _ccutv;
        public string Ccustamp { get; set; }
        private void FrmTv_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Ccutv";
        }
        public override void DefaultValues()
        {
            _ccutv = DoAddline<Ccutv>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_ccutv);
            EF.Save(_ccutv);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _ccutv = FillControls(_ccutv, dt, i);
        }

        private void procura1_Load(object sender, EventArgs e)
        {

        }
    }
}
