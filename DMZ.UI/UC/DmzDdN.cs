using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DmzDdN : UserControl
    {
        public DmzDdN()
        {
            InitializeComponent();
        }
        public string Label3Text
        {
            get => checkBox1.Text;
            set => checkBox1.Text = value;
        }
        public Color Panel1BackColor
        {
            get => panel1.BackColor;
            set => panel1.BackColor = value;
        }
        public ContentAlignment Label1TextAlign
        {
            get => checkBox1.TextAlign;
            set => checkBox1.TextAlign = value;
        }
        public HorizontalAlignment DdNTextAlign
        {
            get => ano.TextAlign;
            set => ano.TextAlign = value;
        }
        public AnchorStyles Label1Anchor
        {
            get => checkBox1.Anchor;
            set => checkBox1.Anchor = value;
        }
        public Font Label1Font
        {
            get => checkBox1.Font;
            set => checkBox1.Font = value;
        }
        public Color label1ForeColor
        {
            get => checkBox1.ForeColor;
            set => checkBox1.ForeColor = value;
        }
        private void DmzDdN_Load(object sender, EventArgs e)
        {

        }

        private void ano_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
