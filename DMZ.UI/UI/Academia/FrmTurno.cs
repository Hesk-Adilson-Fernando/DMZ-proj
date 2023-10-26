using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using System;
using System.Data;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmTurno : FrmClasse
    {
        public FrmTurno()
        {
            InitializeComponent();
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Turno";
        }
        private Turno turno;
        public override void DefaultValues()
        {
            turno = DoAddline<Turno>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(turno);
            EF.Save(turno);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            turno = FillControls(turno, dt, i);
        }
    }
}
