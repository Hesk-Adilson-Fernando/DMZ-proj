using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pericur
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Pericurstamp { get; set; }
        public string Peristamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Nivel { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }
        public string Descperiodo { get; set; }
        public string Anolect { get; set; }
        public virtual Peri Peri { get; set; }
        public virtual ICollection<Pericursem> Pericursem { get; set; }
    }
}
