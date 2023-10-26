using DMZ.BL.Classes;
using DMZ.UI.Basic;
using System;
using System.Windows.Forms;

namespace DMZ.UI.Generic
{
    public partial class FrmGetUserInfo : FrmClasse2 
    {
        public FrmGetUserInfo()
        {
            InitializeComponent();
        }
        private static FrmGetUserInfo _msgBox;
        public static FrmGetUserInfo Show(string text)
        {
            return NewMethod(text,0);
        }
        private static FrmGetUserInfo NewMethod(string text,int height)
        {
            _msgBox = new FrmGetUserInfo();
            _msgBox.tbMessagem.Text = text;
            _msgBox.label1.Text = Pbl.Info;
            _msgBox.ShowInTaskbar = false;
            _msgBox.StartPosition = FormStartPosition.CenterScreen;
            _msgBox.ShowDialog();
            return _msgBox;
        }
        private void FrmGetUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            tbInfo.Text="";
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
