using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.RH
{
    public partial class FrmDiasFeria : Basic.FrmClasse
    {
        public FrmDiasFeria()
        {
            InitializeComponent();
        }
        private DiasFeria DiasFeria;
        private void FrmDiasFeria_Load(object sender, EventArgs e)
        {
            Campo1 = "Dias";
            Campo2 = "descricao";
            Ctabela = "DiasFeria";
        }

        public override void DefaultValues()
        {
            DiasFeria = DoAddline<DiasFeria>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(DiasFeria);
            EF.Save(DiasFeria);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            DiasFeria = FillControls(DiasFeria, dt, i);
        }
    }
}
