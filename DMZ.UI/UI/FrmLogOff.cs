using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Generic;
using System;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmLogOff : Basic.FrmClasse2
    {
        public Action Enviar { get; internal set; }

        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        public FrmLogOff()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
        private void FrmLogOff_Load(object sender, System.EventArgs e)
        {
            tbUser.Text = Pbl.Usr.Login;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (Pbl.Usr.Pw.ToLower().Trim().Equals(textBoxSenha.Text.ToLower().Trim()) && Pbl.Usr.Login.ToLower().Equals(tbUser.Text.ToLower().Trim()))
            {
                Close();
            }
            else
            {
                var usr = SQL.GetRowToEnt<Usr>($"login='{tbUser.Text.ToLower().Trim()}' and pw='{textBoxSenha.Text.ToLower().Trim()}'");
                if (usr != null)
                {
                    Pbl.Usr = usr;
                    Enviar.Invoke();
                    Close();
                }
                else
                {
                    MsBox.Show("A password ou Login inserida está errada!..");
                }
            }
        }

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void lblSoftwareVersion_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
