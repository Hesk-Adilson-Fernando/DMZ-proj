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
    
    public partial class peferias
    {
        public string Descricao { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime termino { get; set; }
        public decimal dias { get; set; }
        public decimal ano { get; set; }
        public bool estado { get; set; }
        public string peferiasstamp { get; set; }
        public string pestamp { get; set; }
        public bool status { get; set; }
    
        public virtual pe pe { get; set; }
    }
}
