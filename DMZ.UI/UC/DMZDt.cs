using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DMZDt : UserControl
    {
        public DMZDt()
        {
            InitializeComponent();
        }
        public string LblText
        {
            get => label2.Text;
            set => label2.Text = value;
        }
        public Font LblFont
        {
            get => label2.Font;
            set => label2.Font = value;
        }
        private void DMZDt_Load(object sender, EventArgs e)
        {

        }
    }
}
