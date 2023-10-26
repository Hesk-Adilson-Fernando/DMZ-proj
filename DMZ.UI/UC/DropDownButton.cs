using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;

namespace DMZ.UI.UC
{
    public partial class DropDownButton : UserControl
    {
        public DropDownButton()
        {
            InitializeComponent();
        }
        [Description("Imagem do Button")]
        public Image ButtonImage
        {
            get => btnOpcoes.Image;
            set => btnOpcoes.Image = value;
        }
        [Description("Cor do panel com texto")]
        public Color PanelTextBackcolor
        {
            get => panelText.BackColor;
            set => panelText.BackColor = value;
        }
        [Description("Cor do panel com texto")]
        public string LabelText
        {
            get => label6.Text;
            set => label6.Text = value;
        }
        public ContentAlignment LabelTextAlign
        {
            get => label6.TextAlign;
            set => label6.TextAlign = value;
        }
        public AnchorStyles LabelTextAnchor
        {
            get => label6.Anchor;
            set => label6.Anchor = value;
        }
        public string Button1ToolTip { get; set; }
        private void DropDownButton_Load(object sender, EventArgs e)
        {
            var tp1 = new ToolTip
            {
                BackColor = Color.DarkCyan,
                ForeColor = Color.White,
                ToolTipTitle = Pbl.Info2,
                ToolTipIcon = ToolTipIcon.Info
            };
            tp1.SetToolTip(btnOpcoes, Button1ToolTip);
            tp1.SetToolTip(pictureBox7, Button1ToolTip);
            tp1.SetToolTip(label6, Button1ToolTip);
            tp1.SetToolTip(panelText, Button1ToolTip);
        }
        public delegate void ClickButton();
        public event ClickButton DoClick;
        public virtual void ButtonClick()
        {
            var handler = DoClick;
            handler?.Invoke();
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
