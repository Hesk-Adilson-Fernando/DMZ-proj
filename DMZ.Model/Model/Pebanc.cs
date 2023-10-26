using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;
namespace DMZ.Model.Model
{
    public class Pebanc
    {
        [Key]
        public string Pebancstamp { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        [DecimalPrecision(16, 0, true)]
        public decimal Conta { get; set; }
        public string Nib { get; set; }
        public string Swift { get; set; }
        public bool Padrao { get; set; }
        public string Obs { get; set; }
        public string Pestamp { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
