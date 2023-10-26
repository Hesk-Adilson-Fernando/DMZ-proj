
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Anolect
    {
        [Key]
        public string Anolectstamp { get; set; }
        public decimal Codigo { get; set; }
        public decimal Ano { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<AnoSem> AnoSem { get; set; }
    }
}
