using System;
using System.Drawing;
using System.Windows.Forms;
using DMZ.UI.Basic;
using DMZ.UI.Classes;

namespace DMZ.UI.UC
{
    public partial class DmzLateralButton : UserControl
    {
        public DmzLateralButton()
        {
            InitializeComponent();
        }
        public delegate void DelegateClickButton();
        public event DelegateClickButton ClickEvent;
        public virtual void ButtonClick()
        {
            var handler = ClickEvent;
            handler?.Invoke();
            BackColorAll();
        }

        private void BackColorAll()
        {
            var lista =Helper.GetAll(ParentForm, typeof(DmzLateralButton));
            if (lista == null) return;
            foreach (var crtl in lista)
            {
                if (crtl.Name.Equals(Name))
                {
                    ((DmzLateralButton) crtl).SetCurrentColor(); 
                }
                else
                {
                    ((DmzLateralButton) crtl).ReSetColor();    
                }
                    
            }
        }

        void SetCurrentColor()
        {
            panelFundo.BackColor =ClickBackColor ;
            tB1.BackColor = ClickBackColor;
            panelLateralSelect.BackColor = Color.White;
            BackColor = ClickBackColor;
        }
        private void ReSetColor()
        {
            panelFundo.BackColor =NormalColor ;
            tB1.BackColor =NormalColor;
            panelLateralSelect.BackColor = NormalColor;
            BackColor = NormalColor;
        }

        public Color NormalColor { get; set; }
        public Font Tb1Font
        {
            get => tB1.Font;
            set => tB1.Font = value;
        }
        public HorizontalAlignment Tb1TextAlign
        {
            get => tB1.TextAlign;
            set => tB1.TextAlign = value;
        }

        public AnchorStyles Tb1Anchor
        {
            get => tB1.Anchor;
            set => tB1.Anchor = value;
        }
        public string TextBox1Text
        {
            get => tB1.Text;
            set => tB1.Text = value;
        }
        public Image BtnImagemImage
        {
            get => btnImagem.Image;
            set => btnImagem.Image = value;
        }
        public Color PanelFundoBackColor
        {
            get => panelFundo.BackColor;
            set
            {
                panelFundo.BackColor = value;
                tB1.BackColor = value;
                panelLateralSelect.BackColor = value;
                BackColor = value;
            }
        }

        public Color ClickBackColor { get; set; }
        public Color Tb1Forcolor
        {
            get => tB1.ForeColor;
            set => tB1.ForeColor = value;
        }
        private void DMZLateralButton_Load(object sender, EventArgs e)
        {

        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }

        private void tB1_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }

        private void panelFundo_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }

        private void panelFundo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
