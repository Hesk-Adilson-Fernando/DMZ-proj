using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DMZEntreDatas : UserControl
    {
        public DMZEntreDatas()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get => checkBox1.Text;
            set => checkBox1.Text = value;
        }
        public Font Label3Font
        {
            get => checkBox1.Font;
            set => checkBox1.Font = value;
        }
        public Color Label3ForeColor
        {
            get => checkBox1.ForeColor;
            set => checkBox1.ForeColor = value;
        }
        public Color Panel1BackColor
        {
            get => panel1.BackColor;
            set => panel1.BackColor = value;
        }
        public bool HideShowDt2 { get =>dt2.Visible;
                                set => dt2.Visible = value;}
        private void EntreDatas_Load(object sender, EventArgs e)
        {

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
