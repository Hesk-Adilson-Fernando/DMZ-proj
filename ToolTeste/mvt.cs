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
    
    public partial class mvt
    {
        public string mvtstamp { get; set; }
        public System.DateTime datamov { get; set; }
        public string origem { get; set; }
        public string oristamp { get; set; }
        public decimal entrada { get; set; }
        public decimal saida { get; set; }
        public string Local { get; set; }
        public decimal codlocal { get; set; }
        public string documento { get; set; }
        public string titulo { get; set; }
        public string numtitulo { get; set; }
        public System.DateTime dprocess { get; set; }
        public bool process { get; set; }
        public decimal nrdoc { get; set; }
        public string dpstamp { get; set; }
        public string qmc { get; set; }
        public System.DateTime qmcdathora { get; set; }
        public string qma { get; set; }
        public System.DateTime qmadathora { get; set; }
        public string Moeda { get; set; }
        public string descricao { get; set; }
        public decimal numeracao { get; set; }
        public decimal saldo { get; set; }
        public bool reconc { get; set; }
        public string extcontastamp { get; set; }
        public string Extracto { get; set; }
        public string Trfstamp { get; set; }
        public string banco { get; set; }
        public string ccusto { get; set; }
        public Nullable<decimal> contatz { get; set; }
        public string referenc { get; set; }
        public string formaspstamp { get; set; }
        public string peemplstamp { get; set; }
        public string Prcempstamp { get; set; }
        public decimal tipomov { get; set; }
        public decimal mentrada { get; set; }
        public decimal msaida { get; set; }
    
        public virtual formasp formasp { get; set; }
        public virtual Trf Trf { get; set; }
    }
}
