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
    public partial class FrmAulino : FrmClasse
    {
        public FrmAulino()
        {
            InitializeComponent();
        }

        private void FrmAulino_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Aulino";
        }
        private Aulino aulino;
        public override void DefaultValues()
        {
            aulino = DoAddline<Aulino>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(aulino);
            EF.Save(aulino);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            aulino = FillControls(aulino, dt, i);
        }
    }
}
