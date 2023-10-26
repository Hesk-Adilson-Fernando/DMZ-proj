using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace DMZ.Model.Generic
{
    public class DateConvention : Convention
    {
        public DateConvention()
        {
            //this.Properties<DateTime>()
            //    .Configure(c => c.HasColumnType("datetime2").HasPrecision(3));

            Properties<DateTime>()
                .Where(x => x.GetCustomAttributes(false).OfType<DataTypeAttribute>()
                    .Any(a => a.DataType == DataType.Date))
                .Configure(c => c.HasColumnType("date"));
        }
    }
}
