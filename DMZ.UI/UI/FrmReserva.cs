using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmReserva : Basic.FrmClasse2
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {
            EditMode = true;
            gridDeb.BindGridView();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
