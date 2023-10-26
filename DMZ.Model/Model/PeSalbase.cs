using DMZ.Model.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class PeSalbase
    {
        [Key]
        public string PeSalbasestamp { get; set; }
        public string Pestamp { get; set; }
        public string Mes { get; set; }
        public string Mesesstamp { get; set; }
        public DateTime Datalanc { get; set; }//data de lancamento
        [DecimalPrecision(16, 2, true)]
        public decimal Nrhoras { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal SalHora { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal ValBasico { get; set; }
        public string Usrstamp { get; set; }
    }
}