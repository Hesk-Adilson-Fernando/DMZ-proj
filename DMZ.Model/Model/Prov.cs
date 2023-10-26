using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{

    public class Prov
    {
        [Key]
        public string Provstamp { get; set; }
        [Required]
        public decimal Codprov { get; set; }
        [Required]
        public string Descricao { get; set; }

        public virtual ICollection<Dist> Dist { get; set; }

    }
}
