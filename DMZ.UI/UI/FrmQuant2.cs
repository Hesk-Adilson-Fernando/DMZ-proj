using DMZ.Model.Model;
using DMZ.UI.Extensions;
using DMZ.UI.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmQuant2 : DMZ.UI.Basic.FrmClasse2
    {
        public FrmQuant2()
        {
            InitializeComponent();
        }

        public DataTable Dt { get; internal set; }
        public bool Operacao { get; set; }
        public Action<DataRow,bool> SendData { get; internal set; }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmQuant2_Load(object sender, EventArgs e)
        {
            if (Dt.HasRows())
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (DataRow item in Dt.AsEnumerable())
                {
                    var c = new DMZProdesp();
                    c.lblDescPos.Text= item["Descpos"].ToString();
                    c.lblPreco.Text = item["Preco"].ToString();
                    c.stQuant = item;
                    flowLayoutPanel1.Controls.Add(c);   
                }
            }
        }
    }
}
