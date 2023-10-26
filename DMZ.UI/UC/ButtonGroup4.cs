using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    public partial class ButtonGroup4 : UserControl
    {
        public ButtonGroup4()
        {
            InitializeComponent();
        }
        public delegate void ClickButton1();
        public event ClickButton1 DoClick1;
        public virtual void ButtonClick1()
        {
            var handler = DoClick1;
            handler?.Invoke();
        }

        public delegate void ClickButton2();
        public event ClickButton2 DoClick2;
        public virtual void ButtonClick2()
        {
            var handler = DoClick2;
            handler?.Invoke();
        }

        public delegate void ClickButton3();
        public event ClickButton3 DoClick3;
        public virtual void ButtonClick3()
        {
            var handler = DoClick3;
            handler?.Invoke();
        }

        public delegate void ClickButton4();
        public event ClickButton4 DoClick4;
        public virtual void ButtonClick4()
        {
            var handler = DoClick4;
            handler?.Invoke();
        }
        [Description("Imagem do Button1")]
        public Image ButtonImage1
        {
            get { return btn1.Image; }
            set { btn1.Image = value; }
        }
        [Description("Imagem do Button2")]
        public Image ButtonImage2
        {
            get { return btn2.Image; }
            set { btn2.Image = value; }
        }
        [Description("Imagem do Button3")]
        public Image ButtonImage3
        {
            get { return btn3.Image; }
            set { btn3.Image = value; }
        }
        [Description("Imagem do Button4")]
        public Image ButtonImage4
        {
            get { return btn4.Image; }
            set { btn4.Image = value; }
        }

        public string Button1ToolTip { get;  set; }
        public string Button2ToolTip { get;  set; }
        public string Button3ToolTip { get;  set; }
        public string Button4ToolTip { get;  set; }

        private void btn1_Click(object sender, EventArgs e)
        {
            ButtonClick1();
        }

        private void ButtonGroup4_Load(object sender, EventArgs e)
        {
            ToolTip tp1 = new DMZToolTip();
            tp1.BackColor = Color.Chocolate;
            tp1.ForeColor = Color.White;
            tp1.ToolTipTitle = Pbl.Info2;
            tp1.ToolTipIcon = ToolTipIcon.Info;
            tp1.SetToolTip(btn1, Button1ToolTip);
            tp1.SetToolTip(btn2, Button2ToolTip);
            tp1.SetToolTip(btn3, Button3ToolTip);
            tp1.SetToolTip(btn4, Button4ToolTip);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ButtonClick2();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ButtonClick3();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ButtonClick4();
        }
    }
}
