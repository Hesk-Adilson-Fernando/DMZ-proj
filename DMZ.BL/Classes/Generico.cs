using DMZ.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DMZ.BL.Classes
{
  public static  class Generico
  {
      public static DateTime SqlDate2 { get; set; } = Pbl.SqlDate;
      public static string Login { get; set; }

      private static bool ToBool(object ob)
      {
          bool ob1;
          bool.TryParse(ob.ToString(),out ob1);
          return ob1;
      }
      public static DataTable SetDefaultDateTime(DataTable dt, List<string> lista)
        {
            foreach (var r in dt.AsEnumerable())
            {
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    if (r[i] is DateTime)
                    {
                        try
                        {
                            var date = Convert.ToDateTime(r[i]);
                            if ((date < (DateTime)SqlDateTime.MinValue) || (date > (DateTime)SqlDateTime.MaxValue))
                            {
                                r[i] = SqlDate2;
                            }
                            else
                            {
                                r[i] = date;
                            }
                            if (dt.Columns[i].ColumnName == "qmadathora")
                            {
                                r[i] = SqlDate2;
                            }
                        }
                        catch
                        {
                            r[i] = (DateTime)SqlDateTime.MinValue;
                        }
                    }
                    if (dt.Columns[i].DataType != typeof(string)) continue;
                    var valor = r[i];
                    if (String.IsNullOrWhiteSpace(valor.ToString()))
                    {
                        if (dt.Columns[i].ColumnName != lista.FirstOrDefault(x => x.Equals(dt.Columns[i].ColumnName)))
                        {
                            r[i] = "";
                        }

                    }
                    if (dt.Columns[i].ColumnName == "qmc" && r.RowState == DataRowState.Added)
                        r[i] = Login;

                    if (dt.Columns[i].ColumnName == "qma")
                        r[i] = Login;
                }
            }
              if (lista == null) return dt;
              foreach (var r in dt.AsEnumerable())
              {
                  for (var i = 0; i < dt.Columns.Count; i++)
                  {
                      var nome = lista.FirstOrDefault(x => x.Equals(dt.Columns[i].ColumnName));
                      if (dt.Columns[i].ColumnName != nome) continue;
                      if (nome != null)
                      {
                          r[i] = DBNull.Value;
                      }
                  }
              }
          return dt;
        }

      public static T SetDefaultValue2<T>(T ef) where T : class, new()
        {
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var lista = GetNavKeyNames<T>();
            foreach (var p in properties.Where(p => p.Name != lista.FirstOrDefault(x => x.Equals(p.Name.Trim()))))
            {
                if (p.PropertyType == typeof (string) && p.GetValue(ef, null) == null)
                {
                    var valor = p.GetValue(ef, null);
                    if (valor == null)
                    {
                        if (p.PropertyType == typeof (string))
                        {
                            p.SetValue(ef, "");
                        }
                    }
                }
                if (p.PropertyType != typeof(DateTime)) continue;
                try
                {
                    var date = Convert.ToDateTime(p.GetValue(ef, null));
                    p.SetValue(ef, date.Year < 1900 ? new DateTime(1900, 1, 1) : date);
                }
                catch
                {
                    p.SetValue(ef, new DateTime(1900, 1, 1));
                }
            }
              foreach (var p in properties)
              {
                  if (p.PropertyType != typeof (string)) continue;
                  var valor = p.GetValue(ef, null);
                  if (valor == null) continue;
                  p.SetValue(ef, valor.ToString().Trim());
              }
            return ef;
        }
      public static T AllTrim<T>(T ef) where T : class, new()
        {
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);         
            foreach (var p in properties)
            {
                if (p.PropertyType != typeof(string)) continue;
                var valor = p.GetValue(ef, null);
                p.SetValue(ef, valor != null ? valor.ToString().Trim() : "");
            }
            return ef;
        }


      public static string GetPrimarykeyName<T>(T ef) where T : class
      {
          var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
          var valor = String.Empty;
          foreach (var p in properties.ToList())
          {
              if (p.Name.ToLower().Contains("stamp"))
              {
                  valor = p.Name;
              }

          }
          return valor;
      }

      public static string GetValue<T>(T ef,string campo) where T : class
        {
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var valor = String.Empty;
            foreach (var p in properties.ToList())
            {
                if (p.Name == campo)
                {
                    valor = p.GetValue(ef, null).ToString();
                }
                
            }
            return valor;
        }
      #region Limpa os Campos nulls de uma Tabela ......

      public static DataTable SetDefault(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                
                if (r.RowState != DataRowState.Deleted)
                {
                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        if (r[i] is DateTime)
                        {
                            try
                            {
                                var date = Convert.ToDateTime(r[i]);
                                if (date.Year < 1900)
                                {
                                    r[i] = new DateTime(1900, 1, 1);
                                }
                                else
                                {
                                    r[i] = date;
                                }
                                if (dt.Columns[i].ColumnName == "qmadathora")
                                {
                                    r[i] = Pbl.SqlDate;
                                }
                            }
                            catch
                            {
                                r[i] = new DateTime(1900, 1, 1);
                            }
                        }
                        if (dt.Columns[i].DataType == typeof(string))
                        {
                            var valor = r[i];
                            if (string.IsNullOrWhiteSpace(valor.ToString()))
                            {
                                r[i] = "";
                            }
                            if (dt.Columns[i].ColumnName == "qmc" && r.RowState == DataRowState.Added)
                            {
                                r[i] = Login;
                            }

                            if (dt.Columns[i].ColumnName == "qma")
                            {
                                r[i] = Login;
                            }
                        }

                        if (dt.Columns[i].DataType == typeof(decimal))
                        {
                            var valor = r[i];
                            if (string.IsNullOrWhiteSpace(valor.ToString()))
                            {
                                r[i] = 0;
                            }
                        }
                        if (dt.Columns[i].DataType == typeof(int))
                        {
                            var valor = r[i];
                            if (string.IsNullOrWhiteSpace(valor.ToString()))
                            {
                                r[i] = 0;
                            }
                        }
                        if (dt.Columns[i].DataType == typeof(bool))
                        {
                            var valor = r[i];
                            r[i] = false;
                            if (!string.IsNullOrWhiteSpace(valor.ToString()))
                            {
                                r[i] = ToBool(valor);
                            }
                            
                        }
                        if (dt.Columns[i].DataType != typeof(DateTime)) continue;
                        var valor2 = r[i];
                        if (string.IsNullOrWhiteSpace(valor2.ToString()))
                        {
                            r[i] = new DateTime(1900, 1, 1); //(DateTime)SqlDateTime.MinValue;
                        }
                    }
                }

            }
            var nomeClasse = dt.TableName;
            var lista = SQLExec.GetGenDT($"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '{nomeClasse.Trim()}' and IS_NULLABLE='YES'");
            if (lista.Rows.Count == 0) return dt;
            foreach (var row in dt.AsEnumerable())
            {
                if (row.RowState == DataRowState.Deleted) continue;
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    var r2 = lista.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(dt.Columns[i].ColumnName));
                    if (r2 == null) continue;
                    if (string.IsNullOrWhiteSpace(row[i].ToString()))
                    {
                        row[i] = DBNull.Value;
                    }
                }
            }
            return dt;
        } 
      #endregion

      //public static Type RowDataType<Type>(this DataRow r,int index)
      //{
      //    Type t;
      //    t = r.Table.Columns[index].DataType;
      //    return t;
      //}
      public static List<string> GetKeyNames<T>() where T : class
        {
          var context = new DataContext();
          var objectSet = ((IObjectContextAdapter) context).ObjectContext.CreateObjectSet<T>();
          var keyNames = objectSet.EntitySet.ElementType.KeyMembers.Select(k => k.Name).ToList();
          return keyNames;
        }
      public static List<string> GetNavKeyNames<T>() where T : class
        {
            var context = new DataContext();
            var objectSet = ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<T>();
            var keyNames = objectSet.EntitySet.ElementType.NavigationProperties.Select(k => k.Name).ToList();
            return keyNames;
        }

      public static PropertyInfo GetProperty<T>(string propertyName, T entity) where T : class
      {
          var p = entity.GetType().GetProperties().FirstOrDefault(xx =>
              xx.Name.ToLower().Trim().Equals(propertyName.ToLower().Trim()));
          return p;
      }

      public static void BindValue<T>(T entity, PropertyInfo p, object value) where T : class
      {
          if (value != null && p != null && p.PropertyType == typeof(string))
          {
              p.SetValue(entity, value.ToString());
          }
          if (value != null && p != null && p.PropertyType == typeof(decimal))
          {
              p.SetValue(entity, value.ToDecimal());
          }

          if (!Convert.IsDBNull(value) && p != null && p.PropertyType == typeof(DateTime))
          {
              p.SetValue(entity, Convert.ToDateTime(value));
          }
          if (p != null && p.PropertyType == typeof(bool))
          {
                p.SetValue(entity, value.ToBool());
          }
          if (p != null && p.PropertyType == typeof(byte[]))
          {
              if (!string.IsNullOrWhiteSpace(value.ToString()))
              {
                  p.SetValue(entity, (byte[])value);
              }
          }
      }

      public static void BindValue<T>(T entity, PropertyInfo p, DataRow dr) where T : class
      {
          dr[p.Name.Trim()] = p.GetValue(entity, null);
          //var type = p.PropertyType.ToString();
          //var ckNull = type.Contains("System.Nullable");
          //if (p != null && p.PropertyType == typeof(string))
          //{
          //    p.SetValue(entity, dr.ToString());
          //}
          //if (p != null && p.PropertyType == typeof(decimal))
          //{
          //    p.SetValue(entity, dr.ToDecimal());
          //}

          //if (p != null && p.PropertyType == typeof(DateTime))
          //{
          //    p.SetValue(entity, Convert.ToDateTime(dr));
          //}
          //if (p != null && p.PropertyType == typeof(bool))
          //{
          //    p.SetValue(entity, dr.ToBool());
          //}
          //if (p != null && p.PropertyType == typeof(byte[]))
          //{
          //    p.SetValue(entity, (byte[])dr);
          //}
      }

      public static void SetToNull<TEntity, TProperty>(this TEntity entity, Expression<Func<TEntity, TProperty>> navigationProperty, DbContext context = null)
          where TEntity : class
          where TProperty : class
      {
          var pi = GetPropertyInfo(entity, navigationProperty);

          if (context != null)
          {
              //If DB Context is supplied, use Entry/Reference method to null out current value
              context.Entry(entity).Reference(navigationProperty).CurrentValue = null;
          }
          else
          {
              //If no DB Context, then lazy load first
              var prevValue = (TProperty)pi.GetValue(entity);
          }

          pi.SetValue(entity, null);
      }

      static PropertyInfo GetPropertyInfo<TSource, TProperty>(TSource source, Expression<Func<TSource, TProperty>> propertyLambda)
      {
          Type type = typeof(TSource);

          MemberExpression member = propertyLambda.Body as MemberExpression;
          if (member == null)
              throw new ArgumentException(string.Format(
                  "Expression '{0}' refers to a method, not a property.",
                  propertyLambda.ToString()));

          PropertyInfo propInfo = member.Member as PropertyInfo;
          if (propInfo == null)
              throw new ArgumentException(string.Format(
                  "Expression '{0}' refers to a field, not a property.",
                  propertyLambda));

          if (type != propInfo.ReflectedType &&
              !type.IsSubclassOf(propInfo.ReflectedType))
              throw new ArgumentException(string.Format(
                  "Expression '{0}' refers to a property that is not from type {1}.",
                  propertyLambda,
                  type));

          return propInfo;
      }

        public static T DoAddline<T>() where T : class, new()
        {
            var t = new T();
            var nomeClasse = typeof(T).Name;
            var lista = SQLExec.GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                $" WHERE table_name = '{nomeClasse.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
            var properties = typeof(T).GetProperties();
            foreach (var p in properties)
            {
                if (p.PropertyType == typeof(string))
                {
                    //p.SetValue(t, "");
                    if (p.Name.Trim().ToLower().Contains("stamp") && p.Name.Trim().ToLower().Contains(nomeClasse.ToLower().Trim()))
                    {
                        //CLocalStamp = Pbl.Stamp();
                        // PrimaryKeyName = p.Name.Trim();
                        p.SetValue(t, Pbl.Stamp());
                    }
                    if (p.Name == "qmc")
                    {
                        p.SetValue(t, Pbl.Login);
                    }

                    if (lista.Rows.Count > 0)
                    {
                        var r = lista.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(p.Name.ToString()));
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
    }
}
