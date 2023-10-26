using System;

namespace DMZ.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class NotEmpty : Attribute
	{
	}
}
