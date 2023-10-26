using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pericursemtur
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Pericursemturstamp { get; set; }
        public string Pericursemstamp { get; set; }
        public string Pericurstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Turclasse { get; set; }
        [MaxLength(400)]
        public string Obs { get; set; }
        public string Sala { get; set; }
        public virtual Pericursem Pericursem { get; set; }
    }
}
