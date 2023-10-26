using System;

namespace DMZ.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class Min : Attribute
	{
		public int Value { get; set; }
	}
}
