using System;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Controls;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class Password : Form
    {
        public string LoginUsr { get;  set; }

        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            lblSoftwareVersion.Text = Pbl.Info;

        }
        private void MouseDownEvent()
        {
            Dllimport.ReleaseCapture();
            Dllimport.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void DMZBD_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void lblSoftwareVersion_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!tbSenhaNova.Text.Trim().Equals(tbSenhaNovaRepetir.Text.Trim()))
            {
                MsBox.Show("A senha inserida não é igual!..");
            }
            else
            {
              var res=  SQLExec.SqlExec($"update usr set pw='{tbSenhaNova.Text.Trim()}' where login='{LoginUsr}' and pw='{tbSenhaActual.Text.Trim()}'");
              if (res==1)
              {
                  MsBox.Show("senha alterada com sucesso");
                  Close();
              }
            }
        }
    }
}
