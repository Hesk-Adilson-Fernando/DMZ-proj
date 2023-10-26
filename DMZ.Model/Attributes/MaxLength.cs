using System;

namespace DMZ.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	public class MaxLength : Attribute
	{
		public int Value { get; set; }
	}
}
