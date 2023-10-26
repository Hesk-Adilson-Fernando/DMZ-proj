

using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Planobolsa
    {
        [Key]
        public string Planobolsastamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        [DecimalPrecision(16, 0, true)]
        public decimal Valor { get; set; }
        [DecimalPrecision(16, 0, true)]
        public decimal Perc { get; set; }
        public bool Condicional { get; set; }//Desconto Condicional 
        public string Tipodesc { get; set; }//Tipo desconto
        public string Accao { get; set; }
    }
}
