using DMZ.DAL.Classes;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DMZ.UI.Classes
{
    public static class ConnHelper
    {
        private static Configuration config;

        static ConnHelper()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public static bool Save(string ds,string db,string pw)
        {
            //ConfiguracaoXml configuracaoXML = new ConfiguracaoXml();
            //configuracaoXML.LerConfiguracaoBanco();
            //string strConn = string.Format("Server={0};Database={1};user={2};password={3}; Integrated Security={4}", configuracaoXML.Servidor, configuracaoXML.BancoDados, configuracaoXML.Usuario
            //    , configuracaoXML.Senha, configuracaoXML.Idmodeintgratd);
           

            //var builder = new SqlConnectionStringBuilder(config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString);


            var builder = new SqlConnectionStringBuilder(SqlHelper.GetConString());

            string password;
            if (pw==null)
            {
                password = builder.Password;
            }
            else
            {
                password = pw;
            }
            //var conx = $"Data Source={ds};Initial Catalog={db};User ID = {builder.UserID.Trim()};Password ={password}; Integrated Security=false";
            //config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString = conx;
            //config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ProviderName = "System.Data.SqlClient";
            //config.Save(ConfigurationSaveMode.Modified);



            try
            {
                string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\XmlPath\\Config.xml";
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                string patht = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
               
                if (!Directory.Exists(patht + "\\XmlPath")
                    || !Directory.Exists(patht + "\\XmlPath" + "\\Config.xml"))
                {
                    if (!Directory.Exists(patht + "\\XmlPath"))
                    {
                        Directory.CreateDirectory(patht + "\\XmlPath");
                    }
                    //Directory.CreateDirectory(patht + "\\XmlPath");
                    StreamWriter objEscreve = new StreamWriter(patht + "\\XmlPath" + "\\Config.xml");
                    objEscreve.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
                    objEscreve.WriteLine("<useroptions>");
                    objEscreve.WriteLine("<idmodeusr>{0}</idmodeusr>", ClsCryptografia.Crypto(builder.UserID.Trim(), true));
                    objEscreve.WriteLine("<idmodebd>{0}</idmodebd>", ClsCryptografia.Crypto(db, true));
                    objEscreve.WriteLine("<idmodesrv>{0}</idmodesrv>", ClsCryptografia.Crypto(ds, true));
                    objEscreve.WriteLine($"<idmodepw>{ClsCryptografia.Crypto(password, true)}</idmodepw>");
                    objEscreve.WriteLine($"<idmodeintgratd>{ClsCryptografia.Crypto("false", true)}</idmodeintgratd>");
                    objEscreve.WriteLine("</useroptions>");
                    objEscreve.Flush();

                    objEscreve.Close();
                }
                // MessageBox.Show("Arquivo de configura\x00e7\x00e3o gravado com sucesso!", "Informa\x00e7\x00f5es", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch 
            {
               // MessageBox.Show("Erro ao tentar gravar arquivo de configura\x00e7\x00e3o : \n" + exception.Message.ToString(), "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            const bool xx = true;
            return xx;
        }

        public static SqlConnection Conection(string ds, string db, string pw)
        {
            //var builder = new SqlConnectionStringBuilder(config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString);
            var builder = new SqlConnectionStringBuilder(SqlHelper.GetConString());
            string password;
            if (pw == null)
            {
                password = builder.Password;
            }
            else
            {
                password = pw;
            }
            var conx = $"Data Source={ds};Initial Catalog={db};User ID = {builder.UserID.Trim()};Password ={password}; Integrated Security=false";

            SqlConnection con = new SqlConnection(conx);
            return con;
        }
    }
}
