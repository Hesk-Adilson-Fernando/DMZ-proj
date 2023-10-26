using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
   public class StFnc
    {
        [Key]
        public string StFncstamp { get; set; }
        public string Ststamp { get; set; }
        public string Fncstamp { get; set; }
        public string Nome { get; set; }
        public decimal Codigo { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Quant { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Devolvido { get; set; }
        public string Reffnc { get; set; }
        public string obs { get; set; }
        public bool Padrao { get; set; }
        public virtual St St { get; set; }
    }
}
