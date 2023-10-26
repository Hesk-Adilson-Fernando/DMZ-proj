using System;
using System.Data;
using System.Data.SqlClient;


namespace DMZ.DAL.Classes
{
    public  class GCon : IDisposable
    {
        #region Conexao
        public SqlConnection NResult { get; set; }
        public string DatabaseName { get; set; }
        private void  ACon()
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(SqlHelper.GetConString());
               NResult = new SqlConnection(SqlHelper.GetConString());
               NResult.Open();
               DatabaseName = builder.InitialCatalog;
            }
            catch (Exception ex)
            {                
                throw new Exception("Ha uma falha na Conecção com servidor!... "+ex);
            }
        }
        #endregion
        private void  FCon()
        {
            if (NResult.State != ConnectionState.Closed)
            {
                NResult.Close();
                NResult.Dispose();
            }
            else
            {
                NResult.Dispose();
            }
        
        }
        public GCon()
        {
            ACon();
        }
        public void Dispose() => FCon();
    }
}

