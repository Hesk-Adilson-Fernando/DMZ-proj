using DMZ.DAL.Classes;
using DMZ.Model.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using static DMZ.BL.Classes.Utilities;

namespace DMZ.BL.Classes
{
    public static class SQL
    {
        private static string _sql;
        private static  GCon _gc ;
        private static SqlCommand _cmd;
        static int _retorno;
        private static string _type;
        private static string _cond2 = string.Empty;
        private static SqlCommand _cmdSql;
        private static SqlDataReader _dr;

        #region Metodos Recém adicionados
        public static T Authentication<T>(string txtUser, string txtPassword) where T : class, new()
        {
            using (_gc = new GCon())
            {
                const string query = @"Select * from usr where login = @login  and pw = @pwd";
                var sqlComando = new SqlCommand(query, _gc.NResult);
                sqlComando.Parameters.AddWithValue("@login", txtUser);
                sqlComando.Parameters.AddWithValue("@pwd", txtPassword);
                var dt = GetReturnTable(sqlComando, "usr");
                return dt?.Rows.Count > 0 ? dt.Rows[0].DrToEntity<T>() : null;
            }
        }
        public static (string usr, string senha, string bd, string servido, bool retorno) GetConectionString()
        {
            string usr = "";
            string senha = ""; string bd = "", servido = "";
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
                MessageBox.Show(exception1.Message.ToString(), "Informa\x00e7\x00e3o", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return (usr, senha, bd, servido, ret);

        }

        public static string Ctabela { get; set; }
        public static string CLocalStamp { get; set; }
        public static string PrimaryKeyName { get; set; }
        public static T DoAddline<T>() where T : class, new()
        {
            var t = new T();
            var nomeClasse = typeof(T).Name;
            var lista = SQL.GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                $" WHERE table_name = '{nomeClasse.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
            var properties = typeof(T).GetProperties();
            foreach (var p in properties)
            {
                if (p.PropertyType == typeof(string))
                {
                    if (!string.IsNullOrEmpty(Ctabela))
                    {
                        if (p.Name.Trim().ToLower().Contains("stamp") && p.Name.Trim().ToLower().Contains(Ctabela.ToLower().Trim()))
                        {
                            CLocalStamp = Pbl.Stamp();
                            PrimaryKeyName = p.Name.Trim();
                            p.SetValue(t, CLocalStamp);
                        }
                    }
                    if (p.Name == "qmc")
                    {
                        p.SetValue(t, Pbl.Usr.Usrstamp);
                    }
                    if (lista.Rows.Count > 0)
                    {
                        var r = lista.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(p.Name));
                        if (r != null)
                        {
                            if (p.Name != "qmc")
                            {
                                p.SetValue(t, null);
                            }
                        }
                    }
                }
                if (p.PropertyType == typeof(DateTime))
                {
                    p.SetValue(t, new DateTime(1900, 1, 1));
                }
                if (p.Name == "qmadathora")
                {
                    p.SetValue(t, new DateTime(1900, 1, 1));
                }
                if (p.Name == "qmcdathora")
                {
                    p.SetValue(t, Pbl.SqlDate);
                }
            }
            return t;
        }

        public static void ExecUsrLogSession(UsrlogSect usrlog)
        {
            try
            {
                //usrlog.ObsfielUsrname = ClsCryptografia.Crypto(usrlog.ObsfielUsrname,true);
                usrlog.ObsUsrPw = ClsCryptografia.Crypto(usrlog.ObsUsrPw, true);
                var xx = EF.Save(usrlog);
                if (xx.ret > 0)
                {
                    Pbl.UsrlogSect = usrlog;
                }
            }
            catch (Exception)
            {
                //
            }
        }
        #endregion

        public static DataRow GetFirstRow(string qry)
        {
            DataRow ret = null;
            var dt = GetGenDT(qry);
            if (dt?.Rows.Count > 0)
            {
                ret = dt.Rows[0];
            }

            return ret;
        }
        public static (string messa, string quer) ConvertToUpdateSql<T>(T obj, string tabe = "", string pkvalue = "")
        {
            SetDefaultSave(obj);
            var nomeClasse = typeof(T).Name;
            var lista = GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                $" WHERE table_name = '{nomeClasse.Trim()}'",
                " DATA_TYPE,LOWER(column_name) column_name,IS_NULLABLE");
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var tableName = nomeClasse;
            var sql = "update " + tableName + " set ";
            var values = new List<object>();
            foreach (var propertyInfo in properties)
            {
                if (lista?.Rows.Count > 0)
                {
                    var row = lista.Select().Where(x => x.Field<string>("column_name").ToLower().Trim().
                            Equals(propertyInfo.Name.ToLower().Trim()))
                        .FirstOrDefault();
                    if (row != null)
                    {
                        var ro = row["IS_NULLABLE"].ToString();
                        var valor = propertyInfo.GetValue(obj);
                        var columnName = propertyInfo.Name;

                        if (propertyInfo.PropertyType.Name == "String" || propertyInfo.PropertyType.Name == "Boolean")
                        {
                            if (!row["IS_NULLABLE"].ToBool())
                            {
                                if (!string.IsNullOrEmpty(tabe))
                                {
                                    if (columnName.ToLower().Contains("stamp") &&
                                        !columnName.ToLower().Equals("formaspstamp".ToLower()))
                                    {
                                        if (string.IsNullOrEmpty(valor.ToString()))
                                        {
                                            propertyInfo.SetValue(obj, null);
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(valor.ToString()))
                                    {
                                        propertyInfo.SetValue(obj, "");
                                        values.Add($@"{columnName}='{propertyInfo.GetValue(obj)}'");
                                        continue;
                                    }
                                }
                            }
                            else
                            {

                                if (string.IsNullOrEmpty(valor.ToString()))
                                {
                                    propertyInfo.SetValue(obj, null);
                                    continue;
                                }
                            }
                            if (columnName.ToLower().Contains("stamp") &&
                                !columnName.ToLower().Equals("Formaspstamp".ToLower()))
                            {
                                if (!string.IsNullOrEmpty(valor.ToString()))
                                {
                                    values.Add($@"{columnName}='{propertyInfo.GetValue(obj)}'");
                                    //values.Add($@"'{propertyInfo.GetValue(obj)}'");
                                }
                            }
                            else
                            {
                                values.Add($@"{columnName}='{propertyInfo.GetValue(obj)}'");
                            }

                        }
                        else if (propertyInfo.PropertyType.Name == "DateTime")
                        {
                            if (!row["IS_NULLABLE"].ToBool())
                            {
                                if (string.IsNullOrEmpty(valor?.ToString()) || !valor.ToString().Contains("0001-"))
                                {
                                    propertyInfo.SetValue(obj, new DateTime(1900, 1, 1));
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(valor.ToString()))
                                {
                                    propertyInfo.SetValue(obj, null);
                                }
                            }
                            var dateTime = (DateTime)propertyInfo.GetValue(obj);

                            values.Add($@"{columnName}='{dateTime.ToString("yyyy-MM-dd")}'");
                        }
                        else
                        {
                            if (!row["IS_NULLABLE"].ToBool())
                            {
                                if (propertyInfo.PropertyType == typeof(byte[]))
                                {
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(valor?.ToString()))
                                    {
                                        propertyInfo.SetValue(obj, 0);
                                    }
                                    values.Add($@"{columnName}='{propertyInfo.GetValue(obj)}'");
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(valor?.ToString()))
                                {
                                    propertyInfo.SetValue(obj, null);
                                }
                                else
                                {
                                    values.Add($@"{columnName}='{propertyInfo.GetValue(obj)}'");
                                }
                            }
                        }
                    }

                }
            }
            sql += $" {string.Join(", ", values)} where {nomeClasse}stamp='{pkvalue}'";
            return ("update", sql);

        }

        public static (T ent, string quer) ConvertToInsertIntoSql<T>(T obj, string tabe = "")
        {
            SetDefaultSave(obj);
            var nomeClasse = typeof(T).Name;
            var lista = GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                $" WHERE table_name = '{nomeClasse.Trim()}'",
                " DATA_TYPE,LOWER(column_name) column_name,IS_NULLABLE");
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);


            var tableName = nomeClasse;
            var sql = "insert into " + tableName + "(";
            var columns = new List<string>();
            var values = new List<object>();
            foreach (var propertyInfo in properties)
            {
                //var item = GetItem<T>(row);
                if (lista?.Rows.Count > 0)
                {
                    var row = lista.Select().Where(x => x.Field<string>("column_name").ToLower().Trim().
                            Equals(propertyInfo.Name.ToLower().Trim()))
                        .FirstOrDefault();
                    if (row != null)
                    {
                        var ro = row["IS_NULLABLE"].ToString();
                        var valor = propertyInfo.GetValue(obj);
                        var columnName = propertyInfo.Name;
                        if (columnName.ToLower().Contains("stamp") &&
                            !columnName.ToLower().Equals("Formaspstamp".ToLower()))
                        {
                            if (!string.IsNullOrEmpty(valor.ToString()))
                            {
                                columns.Add(columnName);
                            }
                        }
                        else
                        {
                            columns.Add(columnName);
                        }
                        if (propertyInfo.PropertyType.Name == "String"
                            || propertyInfo.PropertyType.Name == "Boolean")
                        {
                            if (!row["IS_NULLABLE"].ToBool())
                            {
                                if (!string.IsNullOrEmpty(tabe))
                                {
                                    if (columnName.ToLower().Contains("stamp") &&
                                        !columnName.ToLower().Equals("formaspstamp".ToLower()))
                                    {
                                        if (string.IsNullOrEmpty(valor.ToString()))
                                        {
                                            propertyInfo.SetValue(obj, null);
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(valor.ToString()))
                                    {
                                        propertyInfo.SetValue(obj, "");
                                    }
                                }
                            }
                            else
                            {

                                if (string.IsNullOrEmpty(valor.ToString()))
                                {
                                    propertyInfo.SetValue(obj, null);
                                }
                            }
                            if (columnName.ToLower().Contains("stamp") &&
                                !columnName.ToLower().Equals("Formaspstamp".ToLower()))
                            {
                                if (!string.IsNullOrEmpty(valor.ToString()))
                                {
                                    values.Add($@"'{propertyInfo.GetValue(obj)}'");
                                }
                            }
                            else
                            {
                                values.Add($@"'{propertyInfo.GetValue(obj)}'");
                            }

                        }
                        else if (propertyInfo.PropertyType.Name == "DateTime")
                        {
                            if (!row["IS_NULLABLE"].ToBool())
                            {
                                if (string.IsNullOrEmpty(valor?.ToString()) || !valor.ToString().Contains("0001-"))
                                {
                                    propertyInfo.SetValue(obj, new DateTime(1900, 1, 1));
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(valor.ToString()))
                                {
                                    propertyInfo.SetValue(obj, null);
                                }
                            }
                            var dateTime = (DateTime)propertyInfo.GetValue(obj);

                            values.Add($@"'{dateTime.ToString("yyyy-MM-dd")}'");
                        }
                        else
                        {
                            if (!row["IS_NULLABLE"].ToBool())
                            {
                                if (propertyInfo.PropertyType == typeof(byte[]))
                                {

                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(valor?.ToString()))
                                    {
                                        propertyInfo.SetValue(obj, 0);
                                    }
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(valor?.ToString()))
                                {
                                    propertyInfo.SetValue(obj, null);
                                }
                            }

                            values.Add(propertyInfo.GetValue(obj));
                        }
                    }

                }
            }
            sql += string.Join(", ", columns) + ") values(";
            sql += string.Join(", ", values) + ")";
            return (obj, sql);

        }

        public static T SetDefaultSave<T>(T f)
        {
            var t = f;
            var nomeClasse = typeof(T).Name;
            var lista = GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                $" WHERE table_name = '{nomeClasse.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
            var properties = typeof(T).GetProperties();
            foreach (var p in properties)
            {
                var valor = p.GetValue(t);
                var stamp = $"{nomeClasse}stamp".ToLower();
                if (stamp.Equals(p.Name.ToLower()))
                {
                    if (valor != null)
                    {
                        if (string.IsNullOrEmpty(valor.ToString()))
                        {
                            valor = Pbl.Stamp();
                        }
                    }
                    else if (valor == null)
                    {
                        valor = Pbl.Stamp();
                    }
                }
                if (p.PropertyType == typeof(DateTime))
                {
                    if (valor is DBNull)
                    {
                        valor = new DateTime(1900, 1, 1);
                    }

                    if (valor.ToString().Contains("0001"))
                    {
                        valor = new DateTime(1900, 1, 1);
                    }
                    valor = valor.ToDateTimeValue();

                }
                if (p.PropertyType == typeof(string))
                {
                    var r = lista?.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(p.Name.Trim()));
                    if (r != null)
                    {
                        if (string.IsNullOrEmpty(valor?.ToString()))
                        {
                            valor = "";
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(valor?.ToString()))
                        {
                            valor = "";
                        }
                    }

                }
                if (p.PropertyType == typeof(decimal))
                {
                    if (valor is DBNull)
                    {
                        valor = 0;
                    }
                }
                if (p.PropertyType == typeof(int))
                {
                    if (valor is DBNull)
                    {
                        valor = 0;
                    }
                }
                if (p.PropertyType == typeof(bool))
                {
                    if (valor is DBNull)
                    {
                        valor = false;
                    }
                }
                if (p.PropertyType == typeof(byte[]))
                {

                    if (valor is DBNull)
                    {
                        valor = 0;
                    }
                }
                p.SetValue(t, valor);
            }
            return t;
        }



        public static string GetXmlReport(string rptName)
        {
            return GetField($"select Xmlstring from Rdlcxml where Rdlcname = '{rptName}'")?.ToString();
        }
        public static decimal ExecCambio(string moeda)
        {
            return GetField("top 1 Venda","cambio",$" Moeda='{moeda}' order by data desc").ToDecimal();
        }
        public static (int numero,string messagem) Save(DataTable dt, string tableName,bool adding,string clocalstamp, string ctabela)
        {
            _retorno = 0;
            var _linhaspagada=false;
            if (!(dt?.Rows.Count > 0)) return (-1,$"A tabela {tableName} não tem registos!..");
            _linhaspagada=dt.AsEnumerable().Any(x=>x.RowState == DataRowState.Deleted);
            if (_linhaspagada && dt.Rows.Count==1) return (_retorno,$"Todos registos na tabela {tableName} foram apagados!..");
            try
            {
                using (_gc = new GCon())
                {
                    using (var adapter = new SqlDataAdapter($" SELECT * FROM {tableName} where 1=0 ", _gc.NResult))
                    {   
                        using (new SqlCommandBuilder(adapter))
                        {
                            if (dt.AsEnumerable().Any(x=>x.RowState == DataRowState.Deleted))
                            {
                                dt= dt.AsEnumerable().Where(x=>x.RowState != DataRowState.Deleted).CopyToDataTable();
                            }
                          
                            SetDefault(dt);
                            adapter.Fill(dt);                           
                            adapter.Update(dt);
                            _retorno = 1;
                        }
                    }
                }
                return (_retorno,"Dados Gravados com sucesso!..");
            }
            catch (Exception ex)
            {
                if (adding && !string.IsNullOrEmpty(ctabela))
                {
                    SqlCmd($"delete from {ctabela} where ltrim(rtrim({ctabela}stamp)) ='{clocalstamp.Trim()}'"  );
                }               
                return (_retorno,ex.Message);
            }
        }

        private static string ConvertToInsertIntoSQL(object obj)
		{
			var tableName = obj.GetType().Name;
			var sql = "insert into " + tableName + "(";
			var columns = new List<string>();
			var values = new List<object>();
			foreach (var propertyInfo in obj.GetType().GetProperties())
			{
				var columnName = propertyInfo.Name;
				columns.Add(columnName);
				if (propertyInfo.PropertyType.Name == "String" || propertyInfo.PropertyType.Name == "Boolean")
				{
					values.Add("\"" + propertyInfo.GetValue(obj).ToString() + "\"");
				}
				else if (propertyInfo.PropertyType.Name == "DateTime")
				{
					var dateTime = (DateTime)propertyInfo.GetValue(obj);
					values.Add("\"" + dateTime.ToString("yyyy-MM-dd") + "\"");
				}
				else
				{
					values.Add(propertyInfo.GetValue(obj).ToString());
				}
			}
			sql += string.Join(", ", columns) + ") values(";
			sql += string.Join(", ", values) + ")";
			return sql;
		}
        private static void SetDefault(DataTable dt)
        {
            if (dt?.Rows.Count>0)
            {
                foreach (var dr in dt.AsEnumerable())
                {
                    try
                    {
                        var ctabela = dr.Table.TableName.ToLower();
                        var lista = GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                            $" WHERE table_name = '{ctabela.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
                        foreach (DataColumn col in dr.Table.Columns)
                        {
                            if (col.DataType == typeof(DateTime))
                            {
                                if (dr[col.ColumnName.Trim()] is DBNull)
                                {
                                    dr[col.ColumnName.Trim()] = new DateTime(1900, 1, 1);
                                }
                            }
                            if (col.DataType == typeof(string))
                            {
                                var r = lista?.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(col.ColumnName.Trim()));
                                if (r != null)
                                {
                                    if (string.IsNullOrWhiteSpace(dr[col.ColumnName.Trim()].ToString()))
                                    {
                                        dr[col.ColumnName.Trim()] = null;
                                    }
                                    else if (dr[col.ColumnName.Trim()].ToString() == "")
                                    {
                                        dr[col.ColumnName.Trim()] = null;
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrWhiteSpace(dr[col.ColumnName.Trim()].ToString()))
                                    {
                                        dr[col.ColumnName.Trim()] = "";
                                    }
                                }
                            }
                            if (col.DataType == typeof(decimal))
                            {
                                if (dr[col.ColumnName.Trim()] is DBNull)
                                {
                                    dr[col.ColumnName.Trim()] = 0;
                                }
                            }
                            if (col.DataType == typeof(int))
                            {
                                if (dr[col.ColumnName.Trim()] is DBNull)
                                {
                                    dr[col.ColumnName.Trim()] = 0;
                                }
                            }
                            if (col.DataType == typeof(bool))
                            {
                                if (dr[col.ColumnName.Trim()] is DBNull)
                                {
                                    dr[col.ColumnName.Trim()] = false;
                                }
                            }
                            if (col.DataType == typeof(byte[]))
                            {
                                if (dr[col.ColumnName.Trim()] is DBNull)
                                {
                                    dr[col.ColumnName.Trim()] = 0;
                                }
                            }
                            //if (col.ColumnName.Trim().ToLower().Contains("stamp") && col.ColumnName.Trim().ToLower().Contains(ctabela.ToLower().Trim()))
                            //{
                            //    dr[col.ColumnName.Trim()] = Pbl.Stamp();
                            //}
                            //if (col.ColumnName.Trim().ToLower().Equals(stampLocal.Trim().ToLower()))
                            //{
                            //    dr[stampLocal] = Pbl.Stamp();   
                            //}
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
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
        public static ArrayList ToArrayList(this DataTable dt, string columnName)
        {
            var data = new ArrayList();
            foreach (DataRow row in dt.Rows)
            {
                if (row == null) continue;
                data.Add(row[columnName].ToString());
            }
            return data;
        }
        public static int SqlCmd(string str)
        {
            try
            {
                using (_gc = new GCon())
                {

                    _cmd = new SqlCommand(str, _gc.NResult);
                    var r = _cmd.ExecuteNonQuery();
                    return r;
                }
            }
            catch (Exception)
            {
                return 0;
            }
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
        public static object SQLExecScalar(string str) 
        {
            using (_gc = new GCon())
            {
                _cmd = new SqlCommand(str, _gc.NResult);
                var r = _cmd.ExecuteScalar();
                return r;
            }
        }
        public static object GetFieldValue(string tabela, string campo = null, string filtro = null)
        {
            using (_gc = new GCon())
            {
                if (filtro !=null)
                {
                    filtro = $" where {filtro} ";
                }
                var query = $"SELECT {campo} FROM {tabela}  {filtro}";
                var sqlComando = new SqlCommand(query, _gc.NResult);
                return GetReturnTable(sqlComando,tabela)?.Rows[0][0];
            }
        }
        public static DateTime CurrentData()
        {
            DataTable dtable;
            using (_gc = new GCon())
            {
                var sqlComando = new SqlCommand("SELECT DATEFROMPARTS(CAST((select anoref from param) AS INTEGER), MONTH(getdate()), DAY(getdate())) AS Data", _gc.NResult);
                dtable = GetReturnTable(sqlComando, "");
            }
            return dtable.Rows[0][0].ToDateTimeValue();
        }
        public static DateTime ServerData()
        {
            DataTable dtable ;
            using (_gc = new GCon())
            {
                var sqlComando = new SqlCommand("select GetDate() as Data", _gc.NResult);
                dtable= GetReturnTable(sqlComando, "");
            }
            return dtable.Rows[0][0].ToDateTimeValue();
        }
        public static DataTable GetGenDT(string tabela, string orderbyOrWhere, string select=null)
        {
            using (_gc = new GCon())
            {
                if (select == null)
                {
                    select = "*";
                }
                var query = $"SELECT {select} FROM {tabela}  {orderbyOrWhere}";
                return GetGen2DT(query);
            }
        }

        public static DataTable GetDT(string tabela, string campos = null, string filtro = null, string orderby = null)
        {
            using (_gc = new GCon())
            {
                if (campos==null)
                {
                    campos = "*";
                }

                if (filtro !=null)
                {
                    filtro = $" where {filtro} ";
                }

                if (@orderby !=null)
                {
                    @orderby = $" Order by {@orderby} ";
                }
                var query = $"SELECT {campos} FROM {tabela}  {filtro} {@orderby}";
                var sqlComando = new SqlCommand(query, _gc.NResult);
                return GetReturnTable(sqlComando,tabela);
            }
        }
        public static DataTable GetDT(string tabela,string filtro = null)
        {
            using (_gc = new GCon())
            {
                if (filtro !=null)
                {
                    filtro = $"where {filtro}";
                }
                var query = $"SELECT * FROM {tabela}  {filtro}";
                var sqlComando = new SqlCommand(query, _gc.NResult);
                return GetReturnTable(sqlComando,tabela);
            }
        }
        public static DataRow GetRow(string tabela,string filtro=null)
        {
            DataRow dr = null;
            using (_gc = new GCon())
            {
                if (filtro !=null)
                {
                    filtro = $"where {filtro}";
                }
                else
                {
                    filtro="";
                }
                var query = $"SELECT * FROM {tabela}  {filtro}";
                var sqlComando = new SqlCommand(query, _gc.NResult);
                var dt = GetReturnTable(sqlComando, tabela);
                if (dt?.Rows.Count>0)
                {
                    dr = dt.Rows[0];
                }
                return dr;
            }

        }
        public static DataRow GetRow(string campos,string tabela,string filtro =null)
        {
            DataRow dr = null;
            using (_gc = new GCon())
            {
                if (filtro !=null)
                {
                    filtro = $"where {filtro}";
                }
                else
                {
                    filtro="";
                }
                var query = $"SELECT {campos} FROM {tabela}  {filtro}";
                var sqlComando = new SqlCommand(query, _gc.NResult);
                var dt = GetReturnTable(sqlComando, tabela);
                if (dt?.Rows.Count>0)
                {
                    dr = dt.Rows[0];
                }
                return dr;
            }

        }
        public static DataRow GetRow(string querry)
        {
            DataRow dr = null;
            var dt = GetGen2DT(querry);
            if (dt?.Rows.Count>0)
            {
                dr = dt.Rows[0];
            }
            return dr;
        }
        public static T GetRowToEnt<T>(string condicao =null,string join="") where T : class, new()
        {
            var tabela = new T().GetType().Name;
            string cond = "";
            if (!string.IsNullOrEmpty(condicao))
            {
                cond = $"where {condicao}";
            }
            var querry = $"select * from {tabela} {join} {cond}";
            var dt = GetGen2DT(querry);
            if (dt?.Rows.Count > 0)
            {
                return dt.Rows[0].DrToEntity<T>();
            }
            return null;
        }


        public static DataTable GetGenDT(string qry)
        {
            using (_gc = new GCon())
            {
                try
                {
                    var sqlComando = new SqlCommand(qry, _gc.NResult);
                    var sqlDataAdapter = new SqlDataAdapter(sqlComando);
                    var dtable = new DataTable();
                    sqlDataAdapter.Fill(dtable);
                    return dtable;
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Ambiguous column name 'moeda'"))
                    {
                        if (qry.Contains("rcl."))
                        {
                            qry = qry.Replace("and moeda", "and rcl.moeda");
                        }
                        var sqlComando = new SqlCommand(qry, _gc.NResult);
                        var sqlDataAdapter = new SqlDataAdapter(sqlComando);
                        var dtable = new DataTable();
                        sqlDataAdapter.Fill(dtable);
                        return dtable;
                    }
                }
            }
            return null;
        }
        public static DataTable GetGenDT(string qry,SqlConnection con)
        {
            con.Open();
            var sqlComando = new SqlCommand(qry, con);
            var sqlDataAdapter = new SqlDataAdapter(sqlComando);
            var dtable = new DataTable();
            sqlDataAdapter.Fill(dtable);
            con.Close();
            return dtable;
        }
        public static bool CheckExist(string select)
        {
            var retorno = false;
            if (!string.IsNullOrEmpty(select))
            {
                if (GetGen2DT(select)?.Rows.Count > 0)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool CheckExist(string campos,string tabela,string condicao =null)
        {
            var retorno = false;
            var select = $"select {campos} from {tabela}";
            if (!string.IsNullOrEmpty(condicao))
            {
                select += $" where {condicao}";
            }
            if (GetGen2DT(select)?.Rows.Count > 0)
            {
                retorno = true;
            }
            return retorno;
        }
        public static DataTable GetGen2DT(string tabela, string condicao = null,SqlConnection con=null)
        {
            try
            {
                var querry = $"select * from {tabela}";
                if (!string.IsNullOrEmpty(condicao))
                {
                    querry = $" {querry} where {condicao}";
                }
                if (con==null)
                {
                    using (_gc = new GCon())
                    {
                        var sqlComando = new SqlCommand(querry, _gc.NResult);
                        return GetReturnTable(sqlComando, tabela);
                    }
                }
                else
                {
                    var sqlComando = new SqlCommand(querry,con);
                    return GetReturnTable(sqlComando, tabela);
                }
            }
            catch (Exception ex)
            {
                var dt = new DataTable("Error");
                var col = new DataColumn("ColError", typeof(string));
                dt.Columns.Add(col);
                var r = dt.NewRow();
                r["ColError"] = ex.Message;
                dt.Rows.Add(r);
                return dt;
            }
        }
        public static DataTable  GetGen2DT(string querry)
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
               var dt = new DataTable("Error");
               var col = new DataColumn("ColError", typeof(string));
               dt.Columns.Add(col);
               var r = dt.NewRow();
               r["ColError"] = ex.Message;
               dt.Rows.Add(r);
               return dt;
            }
        }
        internal static DataTable  GetReturnTable(SqlCommand cmd,string tabela)
        {
            var sqlDataAdapter = new SqlDataAdapter(cmd);
            var dtable = new DataTable {TableName = tabela};
            sqlDataAdapter.Fill(dtable);
            return dtable;
        }

        #region Convert DataTable to List of Entity..... 
        public static List<T> DtToList<T>(this DataTable dt) where T : class
        {

            var data = new List<T>();
            if (!(dt?.Rows.Count > 0)) return data;
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;
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
            var entity = Activator.CreateInstance<T>();
                if (dr!=null)
                {
                    if (dr.RowState!=DataRowState.Deleted)
                    {
                        foreach (DataColumn cln in dr.Table.Columns)
                        {
                            if (cln==null) continue;
                            var p = GetProperty(cln.ColumnName, entity);
                            if (p == null) continue;
                            BindValue(entity,p, dr[cln.ColumnName] is DBNull?"":dr[cln.ColumnName]);
                        }
                    }
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
            return table;
        }
        #endregion

        #region Retorna o Maximo de uma tabela ......

        public static decimal VMax(string tabela, decimal numdoc, decimal ano)
        {

          using (_gc = new GCon())
          {
              var qry = numdoc != 0
                  ? $"select ISNULL(max(convert(int,numero)),0) +1 as numero from {tabela} where numdoc={numdoc} and year(data)={ano}"
                  : $"select ISNULL(max(convert(int,numero)),0) +1 as numero from {tabela} where year(data)={ano}";
              var adp = new SqlDataAdapter(new SqlCommand(qry, _gc.NResult));
              var dtable = new DataTable();
              adp.Fill(dtable);
              return dtable.Rows[0][0].ToDecimal();
          }

        }
        public static decimal VMax(string campo,string tabela, string cond=null)
        {

            using (_gc = new GCon())
            {
                var condicao = "";
                if (cond != null)
                {
                    condicao = $" where {cond}";
                }

                var qry = $"select ISNULL(max({campo}),0) +1 as numero from {tabela} {condicao}";
                var adp = new SqlDataAdapter(new SqlCommand(qry, _gc.NResult));
                var dtable = new DataTable();
                adp.Fill(dtable);
                return dtable.Rows[0][0].ToDecimal();
            }

        }
        #endregion
        public static int Maximo(string tabela, string campo, string condicao)
        {
            var number = 0;
            if (!string.IsNullOrEmpty(condicao))
            {
                condicao = $"and {condicao}";
            }
            _sql = $"select ISNULL(max(convert(int,{campo})),0) +1 as {campo} from {tabela} where isnumeric({campo}) = 1 {condicao}";
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

        public static string GetValue(string campo,string tabela,string cond=null)
        {
            var qry = $"select {campo} from {tabela} ";
            if (cond != null)
            {
                qry = $"{qry} where {cond}";
            }
            var dt = GetGen2DT(qry);
            var str = "";
            if (dt?.Rows.Count>0)
            {
                str = dt.Rows[0][0].ToString();
            }
            return str;
        }
        #region Carregamento de ListView.....
        public static string BindGrid(string qry, string tb, string cond1, string cond2, string campo, DataGridView grid, Label label,bool contido)
        {
            var rtn = string.Empty;
            var numer = (from str in qry where char.IsPunctuation(str) select str.ToString()).Where(x => x.Equals(",")).ToList();
            if (!string.IsNullOrEmpty(cond2))
            {
                if (string.IsNullOrEmpty(campo))
                {
                    campo = qry.Split(',')[1];
                }  
            }
            var orderBy = qry.Contains("as") ? "" : $"order by {qry.Split(',')[0]}";
            _cond2 = string.Format(!contido ? " {0} like '{1}%' " : " {0} like '%{1}%' ", campo, cond2);

            _sql = cond2 == string.Empty
                ? cond1 == string.Empty
                    ? $"select {qry} from {tb} {orderBy}"
                    : $"select {qry} from {tb} where {cond1} {orderBy}"
                : cond1 == string.Empty ? $"select {qry} from {tb} where {_cond2} {orderBy} "
                    : $"select {qry} from {tb} where {cond1} and {_cond2} {orderBy} ";

            var qrry = string.Empty;
            var words = new List<string>(qry.Split(','));
            var selwords = string.Empty;
            for (var i = 0; i < words.Count; i++)
            {
                var w = words[i];
                selwords = i == 0 ? "'" + w + "'" : selwords + "," + "'" + w + "'";
            }
            string sql;
            if (!qry.Contains("as"))
            {
               var dt = GetGenDT($"select DATA_TYPE,COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='{tb}' and  rtrim(ltrim(COLUMN_NAME)) in ({selwords})");
                for (var i = 0; i < words.Count; i++)
                {
                    var w = words[i];
                    var type = GetType(dt, w.ToLower());
                    qrry = i == 0 ? w + $"= {type}" : qrry + "," + w + $"= {type}";
                }
                dt.Dispose();
                words.Clear();
                sql = $"select top 1  {qrry} from {tb} " + "  union all " + _sql;
            }
            else
            {
                sql =  _sql;
            }

            var dt2 = GetGenDT(sql);
            if (dt2?.Rows.Count>=0)
            {
                for (var i = 0; i < dt2.Columns.Count; i++)
                {                    
                    if (i>=2)
                    {
                        var dc = new DataGridViewTextBoxColumn {Visible = false, DataPropertyName = dt2.Columns[i].ColumnName};
                        grid.Columns.Add(dc);
                    }
                    else
                    {
                        grid.Columns[i].DataPropertyName = dt2.Columns[i].ColumnName;
                    }
                }
            }
            grid.DataSource = null;
            grid.AutoGenerateColumns = false;
            grid.DataSource = dt2;
            if (dt2 != null) label.Text = dt2.Rows.Count-1 +" Registos";
            return rtn;
        }
        private static string GetType(DataTable dt,string campo)
        {
            string tipo = null;
            var dr = dt.AsEnumerable().FirstOrDefault(x => x.Field<string>("COLUMN_NAME").ToLower().Trim().Equals(campo.Trim()));
            if (dr == null) return null;
            var type = dr["DATA_TYPE"].ToString();
            switch (type)
            {
                case "char":
                case "nvarchar":
                case "varchar":
                case "text":
                    tipo = "''";
                    break;
                case "datetime":
                case "decimal":
                case "numeric":
                case "bit":
                    tipo = "0";
                    break;
            }
            return tipo;
        }
        #endregion
        public static string GetTipo(string tabela,string campo)
        {
            using (_gc = new GCon())
            {
                _sql =$"select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='{tabela.Trim()}' and COLUMN_NAME='{campo}' " +
                      "order by ORDINAL_POSITION ";
                _cmdSql = new SqlCommand(_sql, _gc.NResult);
                _dr = _cmdSql.ExecuteReader();
                while (_dr.Read())
                {
                    _type = _dr[0].ToString();
                }
                return _type;
            }
        }
        public static DataTable SqlSP(string spName, List<SqlParameter> sqlParameter = null)
        {
            using (_gc = new GCon())
            {
                var sqlComando = new SqlCommand(spName, _gc.NResult);
                sqlComando.CommandType = CommandType.StoredProcedure;
                if (sqlParameter!=null)
                {
                    sqlComando.Parameters.AddRange(sqlParameter.ToArray());
                }
                var sqlDataAdapter = new SqlDataAdapter(sqlComando);
                var dtable = new DataTable();
                sqlDataAdapter.Fill(dtable);
                return dtable;
            }
        }
        public static object GetField(string qry)
        {
            object ret = null;
            var dt = GetGenDT(qry);
            if (dt?.Rows.Count>0)
            {
                ret= dt.Rows[0][0];
            }

            return ret;
        }
        public static object GetField(string campo,string tabela,string condicao=null)
        {
            string qry;
            object ret = null;
            qry = condicao==null ? $"select {campo} from {tabela}" : $"select {campo} from {tabela} where {condicao}";

            var dt = GetGenDT(qry);
            if (dt?.Rows.Count>0)
            {
                ret= dt.Rows[0][0];
            }

            return ret;
        }

        public static DataTable  Initialize( string tabela)
        {
            return GetGen2DT($"Select * from {tabela} where 1=0");
        }
        public static DataTable Initialize<T>() where T : class, new()
        {
            var ent = new T();
            DataTable dt = new DataTable(ent.GetType().Name);
            var props = ent.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                if (prop != null)
                {
                    var col = new DataColumn
                    {
                        ColumnName = prop.Name,
                        DataType = prop.PropertyType
                    };
                    dt.Columns.Add(col);
                }
            }
            return dt;
        }
    }
}

