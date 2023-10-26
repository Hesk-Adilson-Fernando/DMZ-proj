using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class StQuant
    {
        [Key]
        public string StQuantstamp { get; set; }
        public string Ststamp { get; set; }
        [DecimalPrecision(20, 2, true)]
        public decimal Quant { get; set; }
        [MaxLength(2000)]
        public string Descpos { get; set; }
        [DecimalPrecision(20, 2, true)]
        public decimal Preco { get; set; }
        public bool Ivainc { get; set; }
        public byte[] Imagem { get; set; }
        public string CCusto { get; set; }
        public string CodCCu { get; set; }
        public string Ccustamp { get; set; }
        public virtual St St { get; set; }

    }
}
