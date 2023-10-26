using System;
using DMZ.BL.Classes;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmCheckUsr : FrmClasse2
    {
        public FrmCheckUsr()
        {
            InitializeComponent();
        }

        public Action<string,bool> SendData { get; set; }

        private void FrmCheckUsr_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
            SendData.Invoke(tbLogin.Text, SQL.CheckExist($"select usrstamp from usr where login='{tbLogin.Text.Trim()}' and pw = '{tbPw.Text.Trim()}' and supervisor =1"));
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MouseDownEvent();
        }
    }
}
