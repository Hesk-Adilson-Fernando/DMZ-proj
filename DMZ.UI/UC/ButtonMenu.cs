using DMZ.BL.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    public partial class ButtonMenu : UserControl
    {
        public ButtonMenu()
        {
            InitializeComponent();
        }
        [Description("Text do Label")]
        public string LabelText
        {
            get => label5.Text;
            set => label5.Text = value;
        }

        [Description("Text do Button")]
        public string ButtonText
        {
            get => button3.Text;
            set => button3.Text = value;
        }
        public Font ButtonFont
        {
            get => button3.Font;
            set => button3.Font = value;
        }
        public Color ButtonForeColor
        {
            get => button3.ForeColor;
            set => button3.ForeColor = value;
        }

        public ContentAlignment ButtonTextAlign
        {
            get => button3.TextAlign;
            set => button3.TextAlign = value;
        }
        [Description("Imagem do Button")]
        public Image ButtonImage
        {
            get => button3.Image;
            set => button3.Image = value;
        }

        [Description("BackColor do panel Text")]
        public Color PanelBackColor
        {
            get => panelText.BackColor;
            set => panelText.BackColor = value;
        }
        public string ButtonToolTip { get; set; }
        private void ButtonMenu_Load(object sender, EventArgs e)
        {
            var tp1 = new DMZToolTip
            {
                BackColor = Color.Chocolate,
                ForeColor = Color.White,
                ToolTipTitle = Pbl.Info2,
                ToolTipIcon = ToolTipIcon.Info
            };
            tp1.SetToolTip(button3, ButtonToolTip);
        }
        public ContentAlignment LabelTextAlign
        {
            get => label5.TextAlign;
            set => label5.TextAlign = value;
        }
        public AnchorStyles LabelTextAnchor
        {
            get => label5.Anchor;
            set => label5.Anchor = value;
        }
        public Bitmap Image { get; internal set; }

        public delegate void ClickButton();
        public event ClickButton DoClick;
        public virtual void ButtonClick()
        {
            var handler = DoClick;
            handler?.Invoke();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
