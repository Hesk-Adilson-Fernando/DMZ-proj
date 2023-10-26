using System.Configuration;
using System.Data.SqlClient;

namespace DMZ.Batch.Classes
{
    public static class ConnHelper
    {
        private static System.Configuration.Configuration config;

        static ConnHelper()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        //Password ={builder.Password.Trim()};
        public static bool Save(string ds,string db,string pw)
        {
            var builder = new SqlConnectionStringBuilder(config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString);
            string password;
            if (pw==null)
            {
                password = builder.Password;
            }
            else
            {
                password = pw;
            }
            var conx = $"Data Source={ds};Initial Catalog={db};User ID = {builder.UserID.Trim()};Password ={password}; Integrated Security=false";
            config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString = conx;
            config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
            const bool xx = true;
            return xx;
        }

        public static SqlConnection Conection(string ds, string db, string pw)
        {
            var builder = new SqlConnectionStringBuilder(config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString);
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
            //config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString = conx;
            //config.ConnectionStrings.ConnectionStrings["DefaultConnection"].ProviderName = "System.Data.SqlClient";
            //config.Save(ConfigurationSaveMode.Modified);
            //const bool xx = true;
            //return xx;
        }
    }
}
