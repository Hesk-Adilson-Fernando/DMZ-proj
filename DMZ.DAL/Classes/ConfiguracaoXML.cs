using DMZ.Model.Model;
using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DMZ.DAL.Classes
{
    public class ConfiguracaoXml
    {
        #region PROPRIEDADES
        public string Servidor { get; set; }
        public string BancoDados { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Idmodeintgratd { get; set; } = "false";
        #endregion

        #region MÉTODOS
        public  (string usr, string senha, string bd, string servido, bool retorno,string integrate) GetConectionString()
        {
            string usr = "";
            string senha = ""; string bd = "", servido = "", integrated = "false";
            bool ret = false;
            try
            {
                string patht = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\XmlPath";
                if (File.Exists(patht + "\\Config.xml"))
                {
                    try
                    {
                        XElement root = XElement.Load(patht + "\\Config.xml");
                        usr = ClsCryptografia.Crypto((string)root.Element("idmodeusr"), false);
                        senha = ClsCryptografia.Crypto((string)root.Element("idmodepw"), false);
                        bd = ClsCryptografia.Crypto((string)root.Element("idmodebd"), false);
                        servido = ClsCryptografia.Crypto((string)root.Element("idmodesrv"), false);
                        integrated = ClsCryptografia.Crypto((string)root.Element("idmodeintgratd"), false);
                        ret = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar carregar as credenciais do usuário!\n\nDetalhe técnico : " + ex.Message, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message, "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return (usr, senha, bd, servido, ret, integrated);

        }

        public void LerConfiguracaoBanco()
        {
            try
            {
                var constr = GetConectionString();
                if (constr.retorno)
                {
                    Senha = constr.senha;
                    Servidor = constr.servido;
                    BancoDados = constr.bd;
                    Usuario = constr.usr;
                    Idmodeintgratd = constr.integrate;
                }
                else
                {
                    MessageBox.Show($@"Ocorreu um erro ao tentar carregar as credenciais do usuário!",
                        "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message.ToString(), "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        #endregion
    }
}
