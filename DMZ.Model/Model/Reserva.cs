using DMZ.Model.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Reserva
    {
        [Key]
        public string Reservastamp { get; set; }
        public string Ccustamp { get; set; }
        public string Usrstamp { get; set; }
        public string Ccusto { get; set; }
        public decimal No { get; set; }
        public string Nome { get; set; }
        public string Clstamp { get; set; }
        public decimal Numero { get; set; }
        public DateTime Datain { get; set; }
        public DateTime Datafim { get; set; }
        public DateTime Horain { get; set; }
        public DateTime Horafim { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Total { get; set; }
        public virtual ICollection<Reserval> Reserval { get; set; }
    }
}
