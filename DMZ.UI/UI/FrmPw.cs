using System;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmPw : Basic.FrmClasse2
    {
        public FrmPw()
        {
            InitializeComponent();
        }

        public string LoginUsr { get; set; }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbSenhaActual.Text.Trim().Equals(Pw.Trim()))
            {
                if (!tbSenhaNova.Text.Trim().Equals(tbSenhaNovaRepetir.Text.Trim()))
                {
                    MsBox.Show("A senha inserida não é igual!..");
                }
                else
                {
                    var res = SQL.SqlCmd($"update usr set pw='{tbSenhaNova.Text.Trim()}' where login='{Pbl.Usr.Login.Trim()}' and pw='{tbSenhaActual.Text.Trim()}'");
                    if (res != 1) return;
                    MsBox.Show("senha alterada com sucesso");
                    Close();
                }
            }
            else
            {
                MsBox.Show("Senha actual está errada!..\r\nPor favor verifique");  
            }
        }

        private void FrmPw_Load(object sender, EventArgs e)
        {
            label1.Text = Pbl.Info;
            Pw = Pbl.Usr.Pw;
            lblUsr.Text = Pbl.Usr.Nome;
        }

        public string Pw { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tbSenhaActual.UseSystemPasswordChar = !tbSenhaActual.UseSystemPasswordChar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbSenhaNova.UseSystemPasswordChar = !tbSenhaNova.UseSystemPasswordChar;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbSenhaNovaRepetir.UseSystemPasswordChar = !tbSenhaNovaRepetir.UseSystemPasswordChar;
        }
    }
}
