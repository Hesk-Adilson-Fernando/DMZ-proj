using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DMZData : UserControl
    {
        public DMZData()
        {
            InitializeComponent();
        }
        public string Label3Text
        {
            get => checkBox1.Text;
            set => checkBox1.Text = value;
        }
        public Font Label3Font
        {
            get => checkBox1.Font;
            set => checkBox1.Font = value;
        }
        public Color Label3Color 
        {
            get => checkBox1.ForeColor;
            set => checkBox1.ForeColor = value;
        }
        public Color Panel1BackColor
        {
            get => panel1.BackColor;
            set => panel1.BackColor = value;
        }
        private void DMZData_Load(object sender, EventArgs e)
        {

        }
    }
}
