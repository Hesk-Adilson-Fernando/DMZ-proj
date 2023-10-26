using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    //[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class BarraText : UserControl
    {
        public BarraText()
        {
            InitializeComponent();
        }
        public Color PanelBackColor
        {
            get => panelText.BackColor;
            set => panelText.BackColor = value;
        }
        public Image PictureBox1Image
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }
        public string Label1Text
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public Font Label1Font
        {
            get => label1.Font;
            set => label1.Font = value;
        }
        public Color Label1ForeColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor = value;
        }
        private void BarraText_Load(object sender, EventArgs e)
        {

        }

        private void panelText_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
