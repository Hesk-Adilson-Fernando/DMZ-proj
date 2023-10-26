using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;

namespace DMZ.UI.UI
{
    public partial class FrmFpagam : DMZ.UI.Basic.FrmClasse
    {
        public FrmFpagam()
        {
            InitializeComponent();
        }
        private Fpagam _fpagam;
        private void FrmFpagam_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Fpagam";
        }

        public override void DefaultValues()
        {
            _fpagam = DoAddline<Fpagam>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_fpagam);
            EF.Save(_fpagam);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _fpagam = FillControls(_fpagam, dt, i);
        }

    }
}
