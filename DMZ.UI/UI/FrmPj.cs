using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmPj : DMZ.UI.Basic.FrmClasse
    {
        public FrmPj()
        {
            InitializeComponent();
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnMenuLateral);
        }
    }
}
