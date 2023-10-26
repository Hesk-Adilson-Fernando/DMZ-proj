using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmSem : DMZ.UI.Basic.FrmClasse
    {
        public FrmSem()
        {
            InitializeComponent();
        }

        private void tbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void FrmSem_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Sem";
        }
        private Sem sem;
        public override void DefaultValues()
        {
            sem = DoAddline<Sem>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(sem);
            EF.Save(sem);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            sem = FillControls(sem, dt, i);
        }
    }
}
