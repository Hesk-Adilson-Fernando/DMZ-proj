using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMZ.UI.Classes;
using EnviarEmail = DMZ.UI.UI.PRC.EnviarEmail;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmEnviarEmail1 : FrmClasse2
    {
        public FrmEnviarEmail1()
        {
            InitializeComponent();
        }
        private void FrmEnviarEmail1_Load(object sender, EventArgs e)
        {
            //poe la um try and cat aonde? essas duas linhas qba
            try
            {
                txtAnexo.Text=Pbl.MyPathName;
                txtEmail.Text=Pbl.Param.EmailRespo;
            }
            catch (Exception ex)
            {

                //
            }



        }
        ArrayList _aAnexosEmail;
        private void btnAnexar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] arr = openFileDialog.FileNames;
                    _aAnexosEmail = new ArrayList();
                    _aAnexosEmail.AddRange(arr);
                    foreach (string s in _aAnexosEmail)
                    {
                        if (!txtAnexo.Text.IsNullOrEmpty())
                        {
                            txtAnexo.Text +=  $@";{s.ToString()} ";
                        }
                        else
                            txtAnexo.Text += s;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnexo.Text))
            {
                txtAnexo.Clear();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var path = string.Empty;//Application.StartupPath;
            var ret = string.Empty;
            var retev = string.Empty;
            //var pt = Application.StartupPath;
            // pt += $"\\DadosdaUGEAd
            // path += $";{pt}";
            if (!Pbl.MyPathName.IsNullOrEmpty())
            {
                // path=Pbl.MyPathName;
                //path+=$"
                if (!string.IsNullOrEmpty(txtAnexo.Text))
                {
                    path += $"{txtAnexo.Text}";
                }
            }
            var arr = path.Split(';');

            //cria um novo arraylist
            _aAnexosEmail = new ArrayList();
            //percorre o array de string e inclui os anexos
            for (int k = 0; k < arr.Length; k++)
            {

                if (!string.IsNullOrEmpty(arr[k].Trim()))
                {
                    _aAnexosEmail.Add(arr[k].Trim());
                }
            }

            if (_aAnexosEmail.Count > 0)
            {
                var email = txtEmail.Text; //dataGridViewFnc.Rows[i].Cells["Email"].Value.ToString();
                retev = EnviarEmail.EnviaEmail.EnviaMensagemComAnexos(email, email,
                    txtAssunto.Text, txtMensagem.Text,
                    _aAnexosEmail);
                if (retev.Contains("Email do destinatário inválido"))
                {
                    ret = retev.ToUpper();
                }
                else if (retev.Contains("The specified string is not in the form required for an e-mail address"))
                {
                    ret = "Endereço electrónico não válido".ToUpper();
                }
                else if (retev.Contains("Mensagem enviada para"))
                {
                    ret = retev.ToUpper();
                }
                else if (retev.Contains($"The SMTP server requires a secure" +
                                        $" connection or the client was not " +
                                        $"authenticated. The server response "))
                {

                    ret = $"Verifique a senha ou endereço electrónico ou\r\nActive a opção Acesso a app menos seguro da".ToUpper() +
                                    $" sua Conta do Google!".ToUpper()+
                                    $"\r\n Erro 01".ToUpper();
                    // ret = $"Verifique a senha e o endereço electrónico\r\n Erro 01".ToUpper();

                    //ret = "Verifique a senha e o endereço electrónico".ToUpper();
                }
                else
                {
                    ret = retev.ToUpper();
                }
                MsBox.Show(Messagem.ParteInicial() + ret);
            }
        }
    }
}
