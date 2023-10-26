using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmAnoSem : Basic.FrmClasse
    {
        public FrmAnoSem()
        {
            InitializeComponent();
        }

        private void FrmAnoSem_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "AnoSem";
            CCondicao = "";
        }
        private AnoSem anoSem;
        public override void DefaultValues()
        {
            anoSem = DoAddline<AnoSem>();
            base.DefaultValues();
            dmzNumero1.nud1.Value = Pbl.SqlDate.Year;
        }
        public override void Save()
        {
            FillEntity(anoSem);
            EF.Save(anoSem);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            anoSem = FillControls(anoSem, dt, i);
        }
    }
}
