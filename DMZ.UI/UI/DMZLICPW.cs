using System;
using DMZ.BL.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class DMZLICPW : Basic.FrmClasse2
    {
        public DMZLICPW()
        {
            InitializeComponent();
        }

        private void DMZLICPW_Load(object sender, EventArgs e)
        {
            label1.Text = Pbl.Info;
            Pw = (Pbl.SqlDate.Day + "" + Pbl.SqlDate.Month + "" + Pbl.SqlDate.Year+"#").Trim();
        }
        public string Pw { get; set; }

        private void btnValorPanelShow_Click(object sender, EventArgs e)
        {
           // if (!textBox1.Text.Trim().Equals(Pw.Trim())) return;
            var b = new DMZLIC();
            b.ShowForm(this);
            Close();
            //if (!string.IsNullOrEmpty(textBox1.Text))
            //{
            //    if (!textBox1.Text.Trim().Equals(Pw.Trim())) return;
            //    var b = new DMZLIC();
            //    b.ShowForm(this);  
            //    Close();
            //}
            //else
            //{
            //    MsBox.Show("O campo não pode ser vazio!");
            //}
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
