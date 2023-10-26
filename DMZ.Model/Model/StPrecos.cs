using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
   public class StPrecos
    {
        [Key]
        public string StPrecostamp { get; set; }
        public string Ststamp { get; set; }
        public string Moeda { get; set; }
        public string CCusto { get; set; }
        public string CodCCu { get; set; }
        public string Ccustamp { get; set; }
        public bool Ivainc { get; set; }
        public bool Padrao { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco { get; set; }

        [DecimalPrecision(16, 2, true)]
        public decimal Preco1 { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco2 { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco3 { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco4 { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco5 { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco6 { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco7 { get; set; }


        [DecimalPrecision(16, 2, true)]
        public decimal PrecoCompra { get; set; }
        [DecimalPrecision(9, 2, true)]
        public decimal Perc { get; set; }
        public virtual St St { get; set; }
    }
}
