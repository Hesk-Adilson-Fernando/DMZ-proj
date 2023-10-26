using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.IMB
{
    public partial class Frmdlei : DMZ.UI.Basic.FrmClasse
    {
        public Frmdlei()
        {
            InitializeComponent();
        }
        private Dlei dlei;
        private void tbReferenc_Load(object sender, EventArgs e)
        {

        }

        private void Frmdlei_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela ="dlei"; 
        }

        public override void DefaultValues()
        {
            dlei = DoAddline<Dlei>();
            base.DefaultValues();
        }
        public override void Save()
        {
            
            FillEntity(dlei);
            EF.Save(dlei);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            dlei = FillControls(dlei, dt, i);
        }
    }
}
