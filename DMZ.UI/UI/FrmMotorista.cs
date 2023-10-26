using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmMotorista : FrmClasse
    {
        private Motorista motorista;

        public FrmMotorista()
        {
            InitializeComponent();
        }

        private void FrmMotorista_Load(object sender, EventArgs e)
        {
            Campo1 = "no";
            Campo2 = "nome";
            Ctabela = "Motorista";
        }
        public override void DefaultValues()
        {
            motorista = DoAddline<Motorista>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(motorista);
            EF.Save(motorista);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            motorista = FillControls(motorista, dt, i);
        }
    }
}
