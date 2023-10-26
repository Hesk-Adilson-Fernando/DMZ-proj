using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    public partial class DmzMinimize : UserControl
    {
        public DmzMinimize()
        {
            InitializeComponent();
        }

        public string FormName { get; set; }
        public string FormText { get; set; }
        private void btnKb_Click(object sender , EventArgs e)
        {
            var form = (FrmClasse) Application.OpenForms[FormName];
            if (form != null)
            {
               form.WindowState = FormWindowState.Normal;
            }
            var crl =((DemoMdi)ParentForm)?.flowLayoutPanel1.Controls.Find(FormName,true);
            if (crl != null) 
                ((DemoMdi) ParentForm)?.flowLayoutPanel1.Controls.Remove(crl[0]);
        }

        private void DmzMinimize_Load(object sender, EventArgs e)
        {
            var tp1 = new DMZToolTip
            {
                BackColor = Color.DarkGoldenrod,
                ForeColor = Color.White,
                ToolTipTitle = Pbl.Info2,
                ToolTipIcon = ToolTipIcon.Info
            };
            tp1.SetToolTip(btnKb, FormText);
        }
    }
}
