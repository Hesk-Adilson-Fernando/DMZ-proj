
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace DMZ.UI.UC
{
    public partial class DashBoradButton : UserControl
    {
        public DashBoradButton()
        {
            InitializeComponent();
        }
        [Description("Text do Label")]
        public string LabelTitulo
        {
            get { return labelTitulo.Text; }
            set { labelTitulo.Text = value; }
        }

        [Description("Text do Label")]
        public string LabelQuantidadeText
        {
            get { return LabelQuantidade.Text; }
            set { LabelQuantidade.Text = value; }
        }
        [Description("Imagem do Button")]
        public Image ButtonImage
        {
            get { return button3.Image; }
            set { button3.Image = value; }
        }
        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
