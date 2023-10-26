using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Planoavall
    {
        [Key]
        public string Planoavallstamp { get; set; }
        public string Planoavalstamp { get; set; }
        [DecimalPrecision(5, 2, true)]
        public decimal Notain { get; set; }
        [DecimalPrecision(5, 2, true)]
        public decimal Notafin { get; set; }
        public string Estado { get; set; }

        

        public string DescexamNrmal { get; set; } //Descrição para normal (reprovado,Recorrência,Aprovado)
        public string DescexamRecor { get; set; } //Descrição para exame de Recorr e especial (reprovado,Aprovado)
      
        public virtual Planoaval Planoaval { get; set; }
    }
}