using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace DMZ.UI.UC
{
    public partial class DmzTextBox : UserControl
    {
        public DmzTextBox()
        {
            InitializeComponent();
        }
        [Category("Date Settings"),Description("data final")]
        public string Data { get; set; }
        [Category("Date Settings"), Description("Nome final")]
        public string Nome { get; set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DmzTextBox_Load(object sender, EventArgs e)
        {

        }
    }

    public enum Formats
    {
        Jan = 1,
        Feb = 2,
        Mar = 3,
        Apr = 4,
        May = 5,
        Jun = 6,
        Jul = 7,
        Aug = 8,
        Sep = 9,
        Oct = 10,
        Nov = 11,
        Dec = 12
    }
}
