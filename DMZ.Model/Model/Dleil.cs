using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Dleil
    {
        [Key]
        public string Dleilstamp { get; set; }
        public string Dleistamp { get; set; }
        public decimal Ano { get; set; }
        [DecimalPrecision(5, 2,true)]
        public decimal Coef { get; set; }
    }
}
