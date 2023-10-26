using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Reflection;
using DMZ.DAL.Classes;
using Configuration = DMZ.DAL.Migrations.Configuration;

namespace DMZ.DAL.Context
{
    public static class MigrateData
    {

        public static string ApplyDatabasePendingMigrations()
        {
            string script = null;
            using (var context = new DataContext())
            {
                var str = SqlHelper.GetConString(); //ConfigurationManager.OpenExeConfiguration("DMZ.UI.EXE").ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
                var configuration = new Configuration
                {
                    ContextType = typeof(DataContext),
                    TargetDatabase = new DbConnectionInfo(str, "System.Data.SqlClient")
                };
                var migrator = new DbMigrator(configuration);
                var migrations = migrator.GetPendingMigrations();
                //var migrations = migrator.GetDatabaseMigrations().AsQueryable().Where(x=>x.Contains("_AutomaticMigration") && x.StartsWith("2020"));
                if (migrations.Any())
                {
                    var scriptor = new MigratorScriptingDecorator(migrator);
                    script = scriptor.ScriptUpdate(null, migrations.Last());
                    if (!string.IsNullOrEmpty(script))
                    {
                        //Console.WriteLine(script);
                        //context.Database.ExecuteSqlCommand(script);
                    }
                }

            }
            return script;
        }

        public static void RunMigration(this DbContext context, DbMigration migration)
        {
            var prop = migration.GetType().GetProperty("Operations", BindingFlags.NonPublic | BindingFlags.Instance);
            if (prop != null)
            {
                var operations = prop.GetValue(migration) as IEnumerable<MigrationOperation>;
                var generator = new SqlServerMigrationSqlGenerator();
                var statements = generator.Generate(operations, "2008");
                foreach (MigrationStatement item in statements)
                    context.Database.ExecuteSqlCommand(item.Sql);
            }


            //using (var context = new AppContext())
            //{
            //    var query = "select top 1 MigrationId from __MigrationHistory order by LEFT(MigrationId, 15) desc";
            //    var migrationId = context.Database.SqlQuery<string>(query).FirstOrDefault();
            //}
        }
        public static string GetConString()
        {
            string script;
            using (var context = new DataContext())
            {
                var configuration = new Configuration
                {
                    ContextType = typeof(DataContext),
                    TargetDatabase = new DbConnectionInfo(context.Database.Connection.ConnectionString, "System.Data.SqlClient")
                };
                script = configuration.TargetDatabase.ToString();

            }
            return script;
        }
        public static void InitializeMigration()
        {
            try
            {
                using (var mdc = new DataContext())
                {
                    mdc.Database.Initialize(true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
