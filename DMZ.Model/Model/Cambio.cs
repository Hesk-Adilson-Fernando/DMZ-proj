using System;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;


namespace DMZ.Model.Model
{
    public class Cambio
    {
        [Key]
        public string Cambiostamp { get; set; }

        [Required]
        public string Moeda { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [DecimalPrecision(14, 2,true)]
        public decimal Compra { get; set; }
        [DecimalPrecision(14, 2,true)]
        public decimal Venda { get; set; }
    }
}
