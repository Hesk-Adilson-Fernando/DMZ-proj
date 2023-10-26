using System.Configuration;
using System.Data;

namespace DMZ.DAL.Classes
{
    public  class SqlHelper
    {
        public static string GetConString()
        {
            try
            {

                ConfiguracaoXml configuracaoXML = new ConfiguracaoXml();
                configuracaoXML.LerConfiguracaoBanco();
                string strConn = string.Format("Server={0};Database={1};user={2};password={3}; Integrated Security={4}", configuracaoXML.Servidor, configuracaoXML.BancoDados, configuracaoXML.Usuario
                    , configuracaoXML.Senha, configuracaoXML.Idmodeintgratd);

                return strConn;
                //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //return config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
            catch (System.Exception)
            {
                return $"";

            }
        }
    }
}
