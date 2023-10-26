using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Clst
    {
        [Key]
        public string Clststamp { get; set; }
        public string Clstamp { get; set; }
        public string Referenc { get; set; }
        public string Descricao { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Preco { get; set; }
        [DecimalPrecision(6, 1, true)]
        public decimal Quant { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
