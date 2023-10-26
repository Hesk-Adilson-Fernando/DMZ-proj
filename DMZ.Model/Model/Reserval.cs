using DMZ.Model.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Reserval
    {
        [Key]
        public string Reservalstamp { get; set; }
        public string Mesastamp { get; set; }//Corresponde a Clstamp
        public string Referenc { get; set; }
        public string Descricao { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Quant { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Valor { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Totall { get; set; }
        public DateTime Din { get; set; }
        public DateTime Dfim { get; set; }
        public DateTime Hin { get; set; }
        public DateTime Hfim { get; set; }
        public string Reservastamp { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
