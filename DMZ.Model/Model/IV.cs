using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class IV
    {
        [Key]
        public string Ivstamp { get; set; }
        public decimal Numdoc { get; set; }
        public string Sigla { get; set; }       
        public string Descricao { get; set; }       
        public decimal Numero { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public DateTime Datalanc { get; set; }
        public bool Lancado { get; set; }
        public string Numinterno { get; set; }
        public string Ccusto { get; set; }
        public string Codccu { get; set; }
        public string Obs { get; set; }
        public virtual ICollection<IVL> IVL { get; set; }
    }
}
