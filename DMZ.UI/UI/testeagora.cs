using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.UC;

namespace DMZ.UI.UI
{
    public partial class testeagora : DMZ.UI.Basic.FrmClasse
    {
        public testeagora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = SQLExec.GetGenDT("select * from st ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pos1 p = new pos1();
                p.Name = "it" + i;
                p.lblPreco.Text = 100.ToString();
                p.lbldescricao.Text = dt.Rows[i]["Descricao"].ToString();
                flowLayoutPanel1.Controls.Add(p);
            }
        }
    }
}
