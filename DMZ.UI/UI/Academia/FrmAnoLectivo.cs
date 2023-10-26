using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmAnoLectivo : Basic.FrmClasse
    {
        public FrmAnoLectivo()
        {
            InitializeComponent();
        }

        private void FrmAnoLectivo_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Anolect";
        }
        private Anolect Anolect;
        public override void DefaultValues()
        {
            Anolect = DoAddline<Anolect>();
            base.DefaultValues();
            dmzNumero1.nud1.Value = Pbl.SqlDate.Year;
        }
        public override void Save()
        {
            FillEntity(Anolect);
            EF.Save(Anolect);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            Anolect = FillControls(Anolect, dt, i);
        }

    }
}
