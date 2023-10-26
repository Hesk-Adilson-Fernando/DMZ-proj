using DMZ.Model.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class PlanoFerial
    {
        [Key]
        public string PlanoFerialstamp { get; set; }
        public string PlanoFeriastamp { get; set; }
        public string Pestamp { get; set; }
        public string Nome { get; set; }
        [DecimalPrecision(10, 2, true)]
        public decimal Saldoferia { get; set; }
        public DateTime Datain { get; set; }
        public DateTime Datater { get; set; }
        [DecimalPrecision(10, 2, true)]
        public decimal Diasnaouteis { get; set; }
        [DecimalPrecision(10, 2, true)]
        public decimal Diasuteis { get; set; }
        [DecimalPrecision(10, 2, true)]
        public decimal Totaldias { get; set; }
        public decimal Anoref { get; set; }
        public decimal Diaslei { get; set; }
        public virtual PlanoFeria PlanoFeria { get; set; }
    }
}
