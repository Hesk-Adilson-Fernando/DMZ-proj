using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmLista : Basic.FrmClasse2
    {
        public FrmLista()
        {
            InitializeComponent();
        }
        public DataTable dt;

        private void FrmLista_Load(object sender, EventArgs e)
        {
            if (dt != null)
            {
                gridPreco.DataSource = null;
                gridPreco.DataSource = dt;
            }
        }
    }
}
