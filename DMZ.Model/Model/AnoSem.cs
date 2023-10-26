using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class AnoSem
    {
        [Key]
        public string AnoSemstamp { get; set; }
        public string Anolectstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Ano { get; set; }
        [MaxLength(2100)]
        public string Obs { get; set; }
        public virtual Anolect Anolect { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
    }
}
