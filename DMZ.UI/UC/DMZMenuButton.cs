using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.UI.UC
{
    public partial class DmzMenuButton : UserControl
    {
        public DmzMenuButton()
        {
            InitializeComponent();
        }
        [Description("Descrição do Menu")]
        public string ButtonText
        {
            get => btnCadastro.Text;
            set => btnCadastro.Text = value;
        }
        [Description("Imagem do Menu")]
        public Image ButtonImage
        {
            get => btnCadastro.Image;
            set => btnCadastro.Image = value;
        }

        [Description("Cor da Imagem do Menu")]
        public Color ButtonColor
        {
            get => btnCadastro.BackColor;
            set => btnCadastro.BackColor = value;
        }

        [Description("Font do Butão Menu")]
        public Font ButtonFont
        {
            get => btnCadastro.Font;
            set => btnCadastro.Font = value;
        }

        [Description("Imagem do Options")]
        public Image PictureBoxImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }
        public string Button1ToolTip { get; set; }
        private void DMZMenuButton_Load(object sender, EventArgs e)
        {
            var tp1 = new ToolTip
            {
                BackColor = Color.DarkCyan,
                ForeColor = Color.White,
                ToolTipTitle = Pbl.Info2,
                ToolTipIcon = ToolTipIcon.Info
            };
            tp1.SetToolTip(btnCadastro, Button1ToolTip);
            tp1.SetToolTip(pictureBox1, Button1ToolTip);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }

        public delegate void ClickButton();
        public event ClickButton DoClick;
        public virtual void ButtonClick()
        {
            var handler = DoClick;
            handler?.Invoke();
        }
    }
}
