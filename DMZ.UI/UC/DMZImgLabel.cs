using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DmzImgLabel : UserControl
    {
        public DmzImgLabel()
        {
            InitializeComponent();
        }
        public Image PicImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image= value;
        }

        public string LabelText
        {
            get => label1.Text;
            set => label1.Text= value;
        }
        public PictureBoxSizeMode PicSizeMode
        {
            get => pictureBox1.SizeMode;
            set => pictureBox1.SizeMode= value;
        }

        public Font LabelFont
        {
            get => label1.Font;
            set => label1.Font= value;
        }

        public Color LabelForeColor
        {
            get => label1.ForeColor;
            set => label1.ForeColor= value;
        }
        public Color LabelBackColor
        {
            get => label1.BackColor;
            set => label1.BackColor= value;
        }
        private void DMZImgLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
