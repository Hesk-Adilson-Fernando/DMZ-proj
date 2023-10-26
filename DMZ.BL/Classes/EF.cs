using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using DMZ.DAL.Classes;
using DMZ.DAL.Context;

namespace DMZ.BL.Classes
{
    //LINQ QUERRY CLASSE 
    public static class EF
    {
        //public static int NovoRegisto { get; set; } = 0;
        public static (int ret, string msg)  Save<T>(T entity, string stamp="") where T : class,new()
        {
            try
            {
                using (var mdc = new DataContext())
                {
                    mdc.Database.Connection.ConnectionString = SqlHelper.GetConString();
                    if (entity == null) return (0,"A Entidade não pode ser vazio");

                    Utilities.AllTrim(entity);
                    var ret = Utilities.PkeyValue(entity,stamp);
                   var existe = SQL.CheckExist($"select {ret.pkName} from {ret.tbName} where {ret.pkName}='{ret.pkValue}'");

                    if (!existe)
                    {
                        mdc.Set<T>().Add(entity);
                    }
                    else //if(NovoRegisto == 2)
                    {
                        mdc.Entry(entity).State = EntityState.Modified;
                    }
                    try
                    {
                        return (mdc.SaveChanges(),"Gravado com sucesso");
                    }
                    catch (DbUpdateException dbEx)
                    {
                        return (-1, dbEx.InnerException.InnerException.ToString());
                    }
                }
            } 
            catch (DbEntityValidationException dbEx)
            {
                var raise = (from validationErrors in dbEx.EntityValidationErrors from validationError in validationErrors.ValidationErrors select
                    $"{validationErrors.Entry.Entity}:{validationError.ErrorMessage}").Aggregate<string, Exception>(dbEx, (current, message) => new InvalidOperationException(message, current));
                throw raise;

            }
        }
    }
}
