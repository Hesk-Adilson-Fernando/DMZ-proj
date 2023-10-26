using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmValor : FrmClasse2
    {
        public FrmValor()
        {
            InitializeComponent();
        }

        public delegate void PassControl(string valor );

        // public delegate void PassControl(object sender,DataTable dt);
        public PassControl SendData;

        private void FrmValor_Load(object sender, EventArgs e)
        {
            KeyUp += KeyEvent;
            KeyPreview = true;
            textBox1.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Goldenrod, ButtonBorderStyle.Solid);
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    SendData.Invoke(textBox1.Text);
                    Close();
                }
               
            }

        }
    }
}
