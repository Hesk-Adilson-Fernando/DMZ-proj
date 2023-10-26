using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmSala : FrmClasse
    {
        private Sala sala;
        public FrmSala()
        {
            InitializeComponent();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Sala";
        }

        public override void DefaultValues()
        {
            sala = DoAddline<Sala>();
            base.DefaultValues();

        }
        public override void Save()
        {
            FillEntity(sala);
            EF.Save(sala);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            sala = FillControls(sala, dt, i);
        }
    }
}
