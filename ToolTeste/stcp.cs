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
    
    public partial class stcp
    {
        public string refcp { get; set; }
        public string descricao { get; set; }
        public decimal quantcp { get; set; }
        public decimal Precocp { get; set; }
        public bool stkprod { get; set; }
        public bool servico { get; set; }
        public bool refstk { get; set; }
        public string stcpstamp { get; set; }
        public string ststamp { get; set; }
        public string refst { get; set; }
        public bool status { get; set; }
    
        public virtual st st { get; set; }
    }
}
