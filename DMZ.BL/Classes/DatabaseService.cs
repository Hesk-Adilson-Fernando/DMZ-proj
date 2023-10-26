using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DMZ.DAL.Classes;

namespace DMZ.BL.Classes
{ 
    public static class DatabaseService
    {
        #region Backup Database ......

        private static  string _backupFolderFullPath;
        private static readonly string[] SystemDatabaseNames = { "master", "tempdb", "model", "msdb" };

        public static (string pat,string dbName) BackupAllUserDatabases()
        {
            var path = Application.StartupPath+"\\Backup";
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            _backupFolderFullPath = path;
            foreach (var databaseName in GetAllUserDatabases())
            {
                Backup(databaseName);
            }
            return (path,DataBaseName);
        }

        private static void Backup(string databaseName)
        {
            var filePath = BuildBackupPathWithFilename(databaseName);
            if (File.Exists(filePath))    
            {    
                File.Delete(filePath);    
            }
            using (var connection = new GCon())
            {
                var query = $"BACKUP DATABASE [{databaseName}] TO DISK='{filePath}'";

                using (var command = new SqlCommand(query, connection.NResult))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        private static string DataBaseName { get; set; }
        private static IEnumerable<string> GetAllUserDatabases()
        {
            var databases = new List<string>();
            DataTable databasesTable;
            using (var connection = new GCon())
            {
                DataBaseName = connection.DatabaseName;
                databasesTable = connection.NResult.GetSchema("Databases");
            }
            foreach (DataRow row in databasesTable.Rows)
            {
                var databaseName = row["database_name"].ToString();

                if (SystemDatabaseNames.Contains(databaseName))
                    continue;
                if (!databaseName.ToLower().Equals(DataBaseName.Trim().ToLower()))
                    continue;
                databases.Add(databaseName);
            }
            return databases;
        }

        private static string BuildBackupPathWithFilename(string databaseName)
        {
            var filename = $"{databaseName}-{DateTime.Now:yyyy-MM-dd}.bak";

            return Path.Combine(_backupFolderFullPath, filename);
        }

        #endregion

        #region Restore Database ....

        public static bool Restore(string backUpPath)
        {
            using (var connection =new  GCon())
            {
                DataBaseName = connection.DatabaseName;
                const string useMaster = "USE master";
                using (var command = new SqlCommand(useMaster, connection.NResult))
                {
                    command.ExecuteNonQuery();
                }
                //var alter1 = $@"ALTER DATABASE [{DataBaseName}] SET Single_User WITH Rollback Immediate";
                //using (var command = new SqlCommand(alter1, connection.NResult))
                //{
                //    command.ExecuteNonQuery();
                //}
                var restore = $@"RESTORE DATABASE [{DataBaseName}] FROM DISK = N'{backUpPath}'  WITH REPLACE, NORECOVERY ";
                using (var command = new SqlCommand(restore, connection.NResult))
                {
                    command.ExecuteNonQuery();
                }
                //var alter2 = $@"ALTER DATABASE [{DataBaseName}] SET Multi_User";
                //using (var command = new SqlCommand(alter2, connection.NResult))
                //{
                //    command.ExecuteNonQuery();
                //}
                Cursor.Current = Cursors.Default;
            }

            return true;
        }

        //private void RestoreDatabase(string localDatabasePath, string fileListDataName, string fileListLogName)
        //{
        //    string localDownloadFilePath = "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\Backup\";
        //    Console.WriteLine($"Restoring database {localDatabasePath}...");
        //    string fileListDataPath = Directory.GetParent(localDownloadFilePath).Parent.FullName + @"\DATA\" + fileListDataName + ".mdf";
        //    string fileListLogPath = Directory.GetParent(localDownloadFilePath).Parent.FullName + @"\DATA\" + fileListLogName + ".ldf";
 
        //    string sql = @"RESTORE DATABASE @dbName FROM DISK = @path WITH RECOVERY,
        //MOVE @fileListDataName TO @fileListDataPath,
        //MOVE @fileListLogName TO @fileListLogPath";
 
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            command.CommandType = CommandType.Text;
        //            command.CommandTimeout = 7200;
        //            command.Parameters.AddWithValue("@dbName", fileListDataName);
        //            command.Parameters.AddWithValue("@path", localDatabasePath);
        //            command.Parameters.AddWithValue("@fileListDataName", fileListDataName);
        //            command.Parameters.AddWithValue("@fileListDataPath", fileListDataPath);
        //            command.Parameters.AddWithValue("@fileListLogName", fileListLogName);
        //            command.Parameters.AddWithValue("@fileListLogPath", fileListLogPath);
 
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    Console.WriteLine(string.Format("Database restoration complete for {0}.", localDatabasePath));
        //}
        #endregion
        //USE [master]
        //GO
        //    RESTORE DATABASE DB_Clients FROM DISK = 'C:\OldDBClients.bak' WITH 
        //    MOVE 'DB_Clients' TO 'D:\SQLServer\Data\DB_Clients.mdf',
        //MOVE 'DB_Clients_log' TO 'D:\SQLServer\Log\DB_Clients.ldf', REPLACE



        //RESTORE DATABASE [mydb_new]
        //FILE = N'<MDFLogicalName>'
        //FROM DISK = N'E:\DBBackups\mydb.bak'
        //WITH 
        //    FILE = 1, NOUNLOAD, STATS = 10,
        //    MOVE N'<MDFLogicalname>'
        //TO N'E:\DBBackups\mydb_new.mdf',
        //MOVE N'<LDFLogicalName>'
        //TO N'E:\DBBackups\mydb_new_0.ldf'


        //USE [master]
        //GO
        //    RESTORE DATABASE DB_Clients FROM DISK = 'C:\OldDBClients.bak' WITH 
        //    MOVE 'DB_Clients' TO 'D:\SQLServer\Data\DB_Clients.mdf',
        //MOVE 'DB_Clients_log' TO 'D:\SQLServer\Log\DB_Clients.ldf', REPLACE
    }
}
