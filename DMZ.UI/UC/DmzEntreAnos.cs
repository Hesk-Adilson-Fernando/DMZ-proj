using System;
using System.Drawing;
using System.Windows.Forms;

namespace DMZ.UI.UC
{
    public partial class DmzEntreAnos : UserControl
    {
        public DmzEntreAnos()
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
        public Color Panel1BackColor 
        {
            get => panel1.BackColor;
            set => panel1.BackColor = value;
        }
        private void DmzEntreAnos_Load(object sender, EventArgs e)
        {

        }
    }
}
