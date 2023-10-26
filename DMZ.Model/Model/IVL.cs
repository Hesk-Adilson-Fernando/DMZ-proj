using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class IVL
    {
        [Key]
        public string Ivlstamp { get; set; }
        public string Ivstamp { get; set; }
        public decimal Numdoc { get; set; }
        public string Sigla { get; set; }
        public string Referenc { get; set; }
        public string Descricao { get; set; }
        public decimal Quant { get; set; }
        public string Unidade { get; set; }
        public decimal Armazem { get; set; }
        public decimal Preco { get; set; }
        public decimal Totall { get; set; }
        public bool Status { get; set; }
        public bool Servico { get; set; }
        public decimal Difer { get; set; }
        public bool Nmovstk { get; set; }
        public string Remotestamp { get; set; }
        public bool Tit { get; set; }
        public decimal Ordem { get; set; }
        public string Titstamp { get; set; }
        public string Lote { get; set; }
        public DateTime Lotevalid { get; set; }
        public DateTime lotelimft { get; set; }
        public bool usalote { get; set; }
        public virtual IV IV { get; set; }
        public virtual ICollection<Mstk> Mstk { get; set; }
    }
}
