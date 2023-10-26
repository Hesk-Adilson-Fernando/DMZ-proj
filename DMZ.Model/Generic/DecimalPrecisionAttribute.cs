using System;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
//using System.Data.Entity.ModelConfiguration.Configuration;

namespace DMZ.Model.Generic
{
    public class DecimalPrecisionAttribute : Attribute
         {
          int _precision;
          int _scale;
          bool _send;
     
         public DecimalPrecisionAttribute(int precision, int scale,bool send)
         {
             _precision = precision;
             _scale = scale;
             _send = send;
         }
  
         public int Precision => _precision;
         public int Scale => _scale;
         public bool Send  => _send;
         }
  
     public class DecimalPrecisionAttributeConvention : PrimitivePropertyAttributeConfigurationConvention<DecimalPrecisionAttribute>//AttributeConfigurationConvention<PropertyInfo, DecimalPropertyConfiguration, DecimalPrecisionAttribute>
    {
         public override void Apply(ConventionPrimitivePropertyConfiguration configuration, DecimalPrecisionAttribute attribute)
         {
             if (attribute.Send)
             {
                 configuration.HasPrecision(Convert.ToByte(attribute.Precision), Convert.ToByte(attribute.Scale));
             }
        }
    }

}
