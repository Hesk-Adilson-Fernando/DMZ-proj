using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;


namespace DMZ.UI.Generic
{
    public partial class MsBox : Form
    {
        public MsBox()
        {
            InitializeComponent();
        }
        #region Grupo Arastar 



        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }
        #endregion

        private static MsBox _msgBox;

        public static MsBox Show(string text, DResult dr)
        {
            return NewMethod(Pbl.Usr == null ? text : $"Estimado(a): {Pbl.Usr.Nome},\r\n" + text, 0);
        }
        public static MsBox Show(string text, string usr, DResult dr)
        {
            return NewMethod(Pbl.Usr == null ? text : $"Estimado(a): {usr},\r\n" + text, 0);
        }
        public static MsBox Show(string text,string usr)
        {
            return NewMethod(Pbl.Usr == null ? text : $"Estimado(a): {usr},\r\n" + text, 0);
        }
        private static MsBox NewMethod(string text,int height)
        {
            _msgBox = new MsBox();
            _msgBox.txtMessage.Text = text;
            _msgBox.lblTitulo.Text = Pbl.Info;
            _msgBox.ShowInTaskbar = false;
            _msgBox.Height =height==0?_msgBox.Height:height;
            _msgBox.btnOk.Visible = false;
            _msgBox.btnYes.Visible=true;
            _msgBox.btnNo.Visible=true;
            _msgBox.pictureBox1.Image = Properties.Resources.Question_Shield_64px;
            _msgBox.ShowDialog();
            return _msgBox;
        }

        public static MsBox Show(string text, DResult dr,int height)
        {
            return NewMethod(text,height);
        }
        public static MsBox Show(string text)
        {
            _msgBox = new MsBox();
            SetValues(Pbl.Usr==null? text:$"Estimado(a): {Pbl.Usr.Nome},\r\n" + text);
            return _msgBox;
        }
        public static MsBox Show(string text, ScrollBars sb)
        {
            _msgBox = new MsBox {txtMessage = {ScrollBars = sb}};
            SetValues(text);
            return _msgBox;
        }
        public static MsBox Show(string text, ScrollBars sb, Color color)
        {
            _msgBox = new MsBox {txtMessage = {ScrollBars = sb, ForeColor = color}};
            SetValues(text);
            return _msgBox;
        }
        public static MsBox Show(string text,Color color,int height)
        {
            _msgBox = new MsBox {Height = height, txtMessage = {ForeColor = color}};
            SetValues(text);
            return _msgBox;
        }
        public static MsBox Show(string text,int height)
        {
            _msgBox = new MsBox
            {
                Height = height,
                txtMessage = {TextAlign = HorizontalAlignment.Left},
                pictureBox1 = {Visible = false}
            };
            SetValues(text);
            return _msgBox;
        }

        private static void SetValues(string text)
        {
            _msgBox.lblTitulo.Text = Pbl.Info;
            _msgBox.txtMessage.Text = text;
            _msgBox.btnOk.Visible = true;
            _msgBox.btnYes.Visible=false;
            _msgBox.btnNo.Visible=false;
            _msgBox.pictureBox1.Image = Properties.Resources.Attention_64px;
            _msgBox.ShowDialog();
            _msgBox.ShowInTaskbar = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MyMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void MsBox_Load(object sender, EventArgs e)
        {

        }

        private void panelYesNo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
