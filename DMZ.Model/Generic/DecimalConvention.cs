using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace DMZ.Model.Generic
{
    public class DecimalConvention : Convention
    {
        public DecimalConvention()
        {
            Properties<decimal>()
                .Where(x => x.GetCustomAttributes(true).OfType<DecimalPrecisionAttribute>().Any(xx => xx.Send.Equals(true)))
                .Configure(c => c.HasPrecision(16, 2));
        }
    }
}
