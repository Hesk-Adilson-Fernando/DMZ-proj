using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Desconto
    {
        [Key]
        public string Descontostamp { get; set; }
        public string Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public decimal Tipo { get; set; }
        [DecimalPrecision(16,2,true)]
        public decimal Valor { get; set; }
        public bool Descfixo { get; set; }
        public bool Decimo13 { get; set; }
        public bool Retro { get; set; }
        public decimal Tipodesc { get; set; }
        public bool Vta { get; set; }
        public decimal Insid { get; set; }
        public bool Rectro { get; set; }
        public string Obs { get; set; }
    }
}
