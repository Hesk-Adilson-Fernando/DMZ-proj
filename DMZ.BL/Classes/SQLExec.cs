using DMZ.DAL.Classes;
using DMZ.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using static DMZ.BL.Classes.Generico;


namespace DMZ.BL.Classes
{
    public static class SQLExec
    {
        private static string _sql;
        private static  GCon _gc ;
        private static SqlCommand _cmd;
        static int _retorno;
        public static AutoCompleteStringCollection AutoComplete(string tabela, string campo)
        {
            AutoCompleteStringCollection myCollection;
            using (_gc = new GCon())
            {
                var cmd = new SqlCommand($"SELECT {campo} FROM {tabela}",_gc.NResult);
                var reader = cmd.ExecuteReader();
                myCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    myCollection.Add(reader.GetString(0));
                }
            }
            return myCollection;
        }       
        public static int Apagar(string tabela, string campo, string stamp, string campo2, string stamp2)
        {
            using (_gc = new GCon())
            {
                _sql =$"delete from {tabela} where ltrim(rtrim({campo}))= '{stamp.Trim()}' and  ltrim(rtrim({campo2}))= '{stamp2.Trim()}'";
                _cmd = new SqlCommand(_sql, _gc.NResult);
                return _cmd.ExecuteNonQuery();
            }
        }
        public static int GravaTabela(DataTable dt, string tableName)
        {
            if (!(dt?.Rows.Count > 0)) return _retorno;
            using (_gc = new GCon())
            {
                using (var adapter = new SqlDataAdapter($" SELECT * FROM {tableName} where 1=0 ", _gc.NResult))
                using (new SqlCommandBuilder(adapter))
                {
                    SetDefault(dt);
                    adapter.Fill(dt);
                    _retorno = adapter.Update(dt);
                }
            }
            return _retorno;
        }
        public static int Apagar(string tabela,string campo,string stamp)
        {
            using (_gc = new GCon())
            {
                _sql = $"delete from {tabela} where ltrim(rtrim({campo}))= '{stamp.Trim()}'";
                _cmd = new SqlCommand(_sql, _gc.NResult);
                return _cmd.ExecuteNonQuery();
            }
        }

        public static int Apagar(string Ctabela, string CLocalStamp)
        {
            var qry = $@"DECLARE @chave varchar(30);
                            DECLARE @Tabela varchar(30);
                            SET @Tabela='{Ctabela}'

                            SELECT @chave=column_name FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                                                WHERE table_name = @Tabela and CONSTRAINT_NAME like('PK%');;
                            DECLARE @qry varchar(200) ;
                            SET @qry= N'delete FROM '+@Tabela+ '  where '+@chave+ '=''{CLocalStamp.Trim()}''';
                            EXEC (@qry)";
            using (_gc = new GCon())
            {
                _cmd = new SqlCommand(qry, _gc.NResult);
                return _cmd.ExecuteNonQuery();
            }
        }
        public static int SqlExec(string str)
        {
            using (_gc = new GCon())
            {

                _cmd = new SqlCommand(str, _gc.NResult);
                var r = _cmd.ExecuteNonQuery();
                return r;
            }
        }
        public static string SqlExec2(string str)
        {
            string retorno;
            using (_gc = new GCon())
            {

                try
                {
                    _cmd = new SqlCommand(str,_gc.NResult);
                    var r = _cmd.ExecuteNonQuery();
                    retorno= r.ToString();
                }
                catch (Exception s)
                {
                   retorno= s.Message;
                }
            }
            return retorno;
        }
        public static int SqlExec(string str, List<SqlParameter> parameters)
        {
            using (_gc = new GCon())
            {
                _cmd = new SqlCommand(str, _gc.NResult) {CommandType = CommandType.StoredProcedure};
                foreach (var param in parameters)
                {
                    _cmd.Parameters.Add(param);
                }
                var r = _cmd.ExecuteNonQuery();
                return r;
            }
        }
        public static DateTime SqlData()
        {

            using (_gc = new GCon())
            {
                var adp = new SqlDataAdapter(new SqlCommand("select GetDate() as Data", _gc.NResult));
                var dtable = new DataTable();
                adp.Fill(dtable);
                return Convert.ToDateTime(dtable.Rows[0][0]);
            }
        }
        public static DataTable GetGenDT(string tabela, string orderbyOrWhere, string select)
        {

            using (_gc = new GCon())
            {
                var query = string.Format("SELECT {2} FROM {0}  {1}", tabela, orderbyOrWhere, select);
                var sqlComando = new SqlCommand(query, _gc.NResult);
                return GetReturnTable(sqlComando,tabela);
            }

        }
        public static DataTable GetGenDT(string qry)
        {
            using (_gc = new GCon())
            {
                var sqlComando = new SqlCommand(qry, _gc.NResult);
                var sqlDataAdapter = new SqlDataAdapter(sqlComando);
                var dtable = new DataTable();
                sqlDataAdapter.Fill(dtable);
                return dtable;
            }
        }
        public static DataTable GetGenDT(string campo,string tabela)
        {

            using (_gc = new GCon())
            {
                var qry = $"select {campo} from {tabela}";
                var sqlComando = new SqlCommand(qry, _gc.NResult);
                var sqlDataAdapter = new SqlDataAdapter(sqlComando);
                var dtable = new DataTable();
                sqlDataAdapter.Fill(dtable);
                return dtable;
            }
        }
        public static bool CheckExist(string qry)
        {
            var retorno = false;
            using (_gc = new GCon())
            {
                var sqlComando = new SqlCommand(qry, _gc.NResult);
                var sqlDataAdapter = new SqlDataAdapter(sqlComando);
                var dtable = new DataTable();
                sqlDataAdapter.Fill(dtable);
                if (dtable.Rows.Count>0)
                {
                    retorno = true;
                }              
            }
            return retorno;
        }
        public static DataTable GetGen2DT(string querry)
        {
            try
            {
                if (querry == null) return null;
                var words = querry.Split(' ');
                var lista = new List<string>();
                for (var i = 0; i < words.Length - 1; i++)
                {
                    if (words[i].ToLower().Equals("from"))
                        lista.Add(words[i + 1]);
                }
                var tabela = lista[0];
                if (string.IsNullOrEmpty(tabela))
                {
                    tabela = "geral";
                }

                using (_gc = new GCon())
                {
                    var sqlComando = new SqlCommand(querry, _gc.NResult);
                    return GetReturnTable(sqlComando, tabela);
                }
            }
            catch (Exception ex)
            {

               throw new Exception(ex.Message);
            }
        }
        internal static DataTable  GetReturnTable(SqlCommand cmd,string tabela)
        {
            var sqlDataAdapter = new SqlDataAdapter(cmd);
            var dtable = new DataTable {TableName = tabela};
            sqlDataAdapter.Fill(dtable);
            return dtable;
        }
        public static DataTable GetApuraTable(string tabela, string orderby, string cond, string select)
        {

            using (_gc = new GCon())
            {
                var sqlComando =
                    new SqlCommand(string.Format("SELECT {3} FROM {0} where {2}  {1}", tabela, orderby, cond, select),
                        _gc.NResult);
                return GetReturnTable(sqlComando,tabela);
            }

        }

        #region Retorna uma Lista de Entities apartir de QUERY usando DataContex................
        public static List<T> EntList<T>(string query) where T : class, new()
        {
            try
            {
                List<T> list;
                using (var mdc = new DataContext())
                {
                    list = mdc.Database.SqlQuery<T>(query).ToList();
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

        public static List<T> EntList<T>(string tab,string cond) where T : class, new()
        {
            try
            {
                List<T> list;
                using (var mdc = new DataContext())
                {
                    var query = $"select * from {tab} where {cond}";
                    list = mdc.Database.SqlQuery<T>(query).ToList();
                }
                return list;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Retorna um Entity especifico apartir de um método generico de QUERY............
        public static T QEnt<T>(string tabela, string where) where T : class, new()
        {
            try
            {
                T entity;
                using (var mdc = new DataContext())
                {
                    var qry = $"select * from {tabela} where {where} ";
                    entity = mdc.Database.SqlQuery<T>(qry).FirstOrDefault();
                }
                return entity;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static T QEnt<T>(string query) where T : class, new()
        {
            try
            {
                T entity;

                using (var mdc = new DataContext())
                {
                    entity = mdc.Database.SqlQuery<T>(query).FirstOrDefault();
                }
                return entity;
            }
            catch(Exception ex)
            {
              throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Executa CRUD Completo............
        public static int Save<T>(T entity) where T : class, new()
        {
            try
            {
                using (var mdc = new DataContext())
                {
                    if (entity == null) return 0;

                    AllTrim(entity);
                    if (Pbl.NovoRegisto)
                    {
                        mdc.Set<T>().Add(entity);
                    }
                    else
                    {
                        mdc.Entry(entity).State = EntityState.Modified;
                    }
                    return mdc.SaveChanges();
                }
            } 
            catch (DbEntityValidationException dbEx)
            {
                var raise = (from validationErrors in dbEx.EntityValidationErrors from validationError in validationErrors.ValidationErrors select
                    $"{validationErrors.Entry.Entity}:{validationError.ErrorMessage}").Aggregate<string, Exception>(dbEx, (current, message) => new InvalidOperationException(message, current));
                throw raise;
            }
        }
        
        public static bool ExistTb(string tableName)
        {
            bool exists;
            using (var mdc = new DataContext())
            {
                exists = mdc.Database
                    .SqlQuery<int?>($@"
                         SELECT 1 FROM sys.tables AS T
                         INNER JOIN sys.schemas AS S ON T.schema_id = S.schema_id
                         WHERE S.Name = 'SchemaName' AND T.Name = '{tableName}'")
                    .SingleOrDefault() != null;
            }
            return exists;
        }
        public static bool ExEntity(string campo, string tb,string value)
        {
            bool exists;
            using (var mdc = new DataContext())
            {
                var qry = $@"SELECT {campo} FROM  {tb} where {campo} = '{value}'";
                var dt = GetGen2DT(qry);
                if (dt?.Rows.Count==0)
                {
                    exists = false;
                }
                else
                {
                    exists = true;
                }
                //exists = 
                //    mdc.Database.SqlQuery<int?>(qry).SingleOrDefault() != null;
            }
            return exists;
        }
        public static int  UpdateEntity<T>(T entity) where T : class, new()
        {
            try
            {
                using (var mdc = new DataContext())
                {
                    if (entity == null) return 0;
                    AllTrim(entity);
                    mdc.Entry(entity).State = EntityState.Modified;
                    return mdc.SaveChanges();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                var raise = (from validationErrors in dbEx.EntityValidationErrors from validationError in validationErrors.ValidationErrors select
                    $"{validationErrors.Entry.Entity}:{validationError.ErrorMessage}").Aggregate<string, Exception>(dbEx, (current, message) => new InvalidOperationException(message, current));
                throw raise;
            }
        }
        public static void DeleteEntity<T>(T entity) where T : class
        {
            try
            {
                using (var mdc = new DataContext())
                {
                    if (entity == null) return;
                    mdc.Entry(entity).State = EntityState.Deleted;
                    mdc.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static object SQLExecScalar(string str) 
        {
            using (_gc = new GCon())
            {
                _cmd = new SqlCommand(str, _gc.NResult);
                var r = _cmd.ExecuteScalar();
                return r;
            }
        }
        #endregion

        #region Convert DataRow para object e objecto to DataRow qualquer .....
        public static T ConvDrEnt<T>(DataRow dataRow, T entity) where T : class, new()
        {
            var lista = GetNavKeyNames<T>();
            //--- o type é necessário para obter as propriedades do objecto
            if (entity ==null)
            {
                entity = new T();
            }          
            var t = entity.GetType();
            //--- obtem as propriedades o objecto
            var propertiesList = t.GetProperties();

            foreach (var prop in propertiesList)
            {
                try
                {
                    //--- coloca o valor da datarow na propriedade correcta do objecto
                    if (lista==null)
                    {
                        t.InvokeMember(prop.Name, BindingFlags.SetProperty, null,
                                entity,
                                new[] { dataRow[prop.Name] }); 
                    }
                    else
                    {
                        if (prop.Name == lista.FirstOrDefault(x => x.Equals(prop.Name.Trim()))) continue;
                        var existe = dataRow.Table.Columns.Contains(prop.Name);
                        if (existe)
                        {
                            t.InvokeMember(prop.Name, BindingFlags.SetProperty, null,
                                entity,
                                new[] {dataRow[prop.Name]??""});
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        return entity;
        }
        public static void  ConvEtoDr<T>(DataTable dt, T entity) where T : class, new()
        {
            //--- o type é necessário para obter as propriedades do objecto
            var t = entity.GetType();
            SetDefaultValue2(entity);
            var lista = GetNavKeyNames<T>();
            var dr = dt.NewRow(); 
            //--- obtem as propriedades o objecto
            var propertiesList = t.GetProperties();
            foreach (var properties in propertiesList)
            {
                try
                {
                    //dr[properties.Name] = t.GetProperty(properties.Name).GetValue(objectType, null);  
                    if (lista == null)
                    {
                        t.InvokeMember(properties.Name, BindingFlags.SetProperty, null,
                                entity,
                                new[] { dr[properties.Name] });
                    }
                    else
                    {
                        if (properties.Name != lista.FirstOrDefault(x => x.Equals(properties.Name.Trim())))
                        {
                            t.InvokeMember(properties.Name, BindingFlags.SetProperty, null,
                             entity,
                             new[] { dr[properties.Name] });
                        }
                    }
                }
                catch (Exception)
                {
                   // throw new Exception(ex.ToString());
                }
            }
            dt.Rows.Add(dr);
        }

        #endregion

        #region Convert DataTable to List of Entity..... 
        public static List<T> DtToList<T>(this DataTable dt) where T : class
        {
            var data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                var item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static List<string> ToList(this DataTable dt,string columnName)
        {
            var data = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                if (row==null) continue;
                data.Add(row[columnName].ToString());
            }
            return data;
        }
        public static T DrToEntity<T>(this DataRow row) where T : class, new()
        {
            var data = GetItem<T>(row);
            return data;
        }
        public static void DataFromEntity<T>(this DataRow dr,T entity ) where T : class
        {
            if (dr==null) return;
            foreach (DataColumn cln in dr.Table.Columns)
            {
                if (cln == null) continue;
                var p = GetProperty(cln.ColumnName, entity);
                if (p == null) continue;
                dr[cln.ColumnName] = p.GetValue(entity, null);
            }
        }
        public static void AddNewRow<T>(this DataTable dt,T entity ) where T : class
        {
            var dr = dt.NewRow();
            foreach (DataColumn cln in dr.Table.Columns)
            {
                if (cln == null) continue;
                var p = GetProperty(cln.ColumnName, entity);
                if (p == null) continue;
                dr[cln.ColumnName] = p.GetValue(entity, null);
                // BindValue(entity, p, dr[cln.ColumnName]);
            }

            dt.Rows.Add(dr);

        }
        public static void AddRow<T>(this DataTable dt, T entity) where T : class
        {
            var dr = dt.Rows.Count>0 ? dt.Rows[dt.Rows.Count-1] : dt.NewRow();
                
            foreach (DataColumn cln in dr.Table.Columns)
            {
                if (cln == null) continue;
                var p = GetProperty(cln.ColumnName, entity);
                if (p == null) continue;
                dr[cln.ColumnName] = p.GetValue(entity, null);
                // BindValue(entity, p, dr[cln.ColumnName]);
            }

            if (dt.Rows.Count == 1)
            {
                dt.Rows.Add(dr);
            }
        }
        private static T GetItem<T>(DataRow dr) where T : class
        {
            var temp = typeof(T);
            var entity = Activator.CreateInstance<T>();
            foreach (DataColumn cln in dr.Table.Columns)
            {
                if (cln==null) continue;
                var p = GetProperty(cln.ColumnName, entity);
                if (p == null) continue;
                BindValue(entity,p, dr[cln.ColumnName]);
                //foreach (var p in temp.GetProperties())
                //{

                //    if (p.Name.ToLower().Trim().Equals(cln.ColumnName.ToLower().Trim()))
                //    {
                //        var valor = dr[cln.ColumnName];
                //        var type = p.PropertyType.ToString();
                //        var ckNull = type.Contains("System.Nullable");
                //        if (ckNull)
                //        {
                //            var xx = type.Substring(18, 14);
                //            if (xx == "System.Decimal")
                //            {
                //                p.SetValue(entity, Pbl.CToD(valor.ToString()));
                //            }

                //            xx = type.Substring(18, 13);
                //            if (xx == "System.String")
                //            {
                //                p.SetValue(entity, valor.ToString());
                //            }

                //            xx = type.Substring(18, 14);
                //            if (xx == "System.Boolean")
                //            {
                //                p.SetValue(entity, valor);
                //            }

                //            if (xx == "System.DateTime")
                //            {
                //                p.SetValue(entity, Convert.ToDateTime(valor));
                //            }

                //            if (xx == "System.Byte[]")
                //            {
                //                p.SetValue(entity, valor);
                //            }
                //        }
                //        else
                //        {
                //            if (p.PropertyType == typeof(DateTime))
                //            {
                //                try
                //                {
                //                    var date = Convert.ToDateTime(valor);
                //                    p.SetValue(entity, date.Year < 1900 ? new DateTime(1900, 1, 1) : date);
                //                }
                //                catch
                //                {
                //                    p.SetValue(entity, new DateTime(1900, 1, 1));
                //                }
                //            }
                //            else if (p.PropertyType == typeof(decimal))
                //            {
                //                p.SetValue(entity, Pbl.CToD(valor.ToString()));
                //            }
                //            else if (p.PropertyType == typeof(bool))
                //            {
                //                p.SetValue(entity, Pbl.ToBool(valor.ToString()));
                //            }
                //            else if (p.PropertyType == typeof(string))
                //            {
                //                p.SetValue(entity, string.IsNullOrWhiteSpace(valor.ToString()) ? "" : valor.ToString());
                //            }

                //            else if (p.PropertyType == typeof(DateTime) && p.GetValue(entity).Equals(null))
                //            {
                //                p.SetValue(entity, Convert.ToDateTime(valor));
                //            }
                //            else if (p.PropertyType == typeof(byte[]))
                //            {
                //                p.SetValue(entity, Encoding.ASCII.GetBytes(valor.ToString()));
                //            }
                //        }
                //    }
                //}
            }
            return entity;
        }
        public static IQueryable<T> Search<T>(this IQueryable<T> source, Expression<Func<T, string>> stringProperty, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return source;
            }

            // The below represents the following lamda:
            // source.Where(x => x.[property] != null
            //                && x.[property].Contains(searchTerm))

            //Create expression to represent x.[property] != null
            var isNotNullExpression = Expression.NotEqual(stringProperty.Body,
                                                          Expression.Constant(null));

            //Create expression to represent x.[property].Contains(searchTerm)
            var searchTermExpression = Expression.Constant(searchTerm);
            var checkContainsExpression = Expression.Call(stringProperty.Body, typeof(string).GetMethod("Contains"), searchTermExpression);

            //Join not null and contains expressions
            var notNullAndContainsExpression = Expression.AndAlso(isNotNullExpression, checkContainsExpression);

            var methodCallExpression = Expression.Call(typeof(Queryable),"Where",new[] { source.ElementType },
                                                       source.Expression,
                                                       Expression.Lambda<Func<T, bool>>(notNullAndContainsExpression, stringProperty.Parameters));

            return source.Provider.CreateQuery<T>(methodCallExpression);
        }
        public static DataTable ToDataTable<T>(this T entity) where T : class
        {
            var properties = typeof(T).GetProperties();
            var table = new DataTable {TableName = entity.GetType().Name};

            foreach (var property in properties)
            {
                var type = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                table.Columns.Add(property.Name, type);
            }
            table.Rows.Add(properties.Select(p => p.GetValue(entity, null)).ToArray());
            //foreach (var entity in entityList)
            //{

            //}
            return table;
        }
        #endregion

        #region Retorna o Maximo de uma tabela ......

        public static decimal VMax(string tabela, decimal numdoc, decimal ano)
        {

          using (_gc = new GCon())
          {
              var qry = numdoc != 0
                  ? $"select ISNULL(max(numero),0) +1 as numero from {tabela} where numdoc={numdoc} and year(data)={ano}"
                  : $"select ISNULL(max(numero),0) +1 as numero from {tabela} where year(data)={ano}";
              var adp = new SqlDataAdapter(new SqlCommand(qry, _gc.NResult));
              var dtable = new DataTable();
              adp.Fill(dtable);
              return (decimal) dtable.Rows[0][0];
          }

        }

        public static decimal VMax(string qry)
        {

            using (_gc = new GCon())
            {
                var adp = new SqlDataAdapter(new SqlCommand(qry, _gc.NResult));
                var dtable = new DataTable();
                adp.Fill(dtable);
                return (decimal)dtable.Rows[0][0];
            }

        }
        #endregion
        public static string GetDBN() => new DataContext().Database.Connection.Database;

        public static int Maximo(string tabela, string campo, string condicao)
        {
            var number = 0;
            if (condicao == string.Empty)
            {
                _sql = "select ISNULL(max(convert(int," + campo + ")),0) +1 as " + campo + " from " + tabela;
            }
            else
            {
                _sql = "select ISNULL(max(Convert(int," + campo + ")),0) +1 as " + campo + " from " + tabela + " where " + condicao;
            }
            using (_gc = new GCon())
            {
                var sqlComando = new SqlCommand(_sql, _gc.NResult);
                var sqlDataAdapter = new SqlDataAdapter(sqlComando);
                var dtable = new DataTable();
                sqlDataAdapter.Fill(dtable);
                if (dtable.Rows.Count > -1)
                {
                    number = Convert.ToInt32(dtable.Rows[0][0]);
                }
            }

            return number;
        }

        public static string GetValue(string s)
        {
            var dt = GetGen2DT(s);
            var str = "";
            if (dt?.Rows.Count>0)
            {
                str = dt.Rows[0][0].ToString();
            }
            return str;
        }
    }
}

