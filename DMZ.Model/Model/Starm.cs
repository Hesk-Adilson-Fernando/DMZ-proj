using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public  class Starm
    {
        [Key]
        public string Starmstamp { get; set; }
        public string Ststamp { get; set; }
        public decimal Codarm { get; set; }
        public string Descricao { get; set; }
        public string Ref { get; set; }
        [DecimalPrecision(20, 2,true)]
        public decimal Stock { get; set; }
        [DecimalPrecision(20, 2,true)]
        public decimal StockMin { get; set; }
        [DecimalPrecision(20, 2,true)]
        public decimal StockMax { get; set; }
        [DecimalPrecision(20, 2,true)]
        public decimal Reserva { get; set; }
        public decimal Encomenda { get; set; }
        [DecimalPrecision(20, 2,true)]
        public decimal Vendido { get; set; } 
        [DecimalPrecision(20, 2,true)]
        public decimal Comprado { get; set; } 
        public bool Padrao { get; set; }
        public string Endereco { get; set; }
        public virtual St St { get; set; }
    }
}
