using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pericursem
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Pericursemstamp { get; set; }
        public string Pericurstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        [MaxLength(400)]
        public string Obs { get; set; }
        public virtual Pericur Pericur { get; set; }
        public virtual ICollection<Pericursemtur> Pericursemtur { get; set; }
    }
}
