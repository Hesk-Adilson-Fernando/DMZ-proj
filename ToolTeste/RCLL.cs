//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    
    public partial class RCLL
    {
        public string rcllstamp { get; set; }
        public string rclstamp { get; set; }
        public string ccstamp { get; set; }
        public System.DateTime data { get; set; }
        public decimal nrdoc { get; set; }
        public string descricao { get; set; }
        public decimal valorpreg { get; set; }
        public decimal valorreg { get; set; }
        public bool status { get; set; }
        public string numinterno { get; set; }
        public string origem { get; set; }
        public decimal mvalorpreg { get; set; }
        public decimal mvalorreg { get; set; }
    
        public virtual RCL RCL { get; set; }
    }
}
