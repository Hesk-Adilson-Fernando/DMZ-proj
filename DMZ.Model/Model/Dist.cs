using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DMZ.Model.Model
{
   public class Dist
    {
        [Key]
        public string Diststamp { get; set; }
        [Required]
        public decimal Codprov { get; set; }
        [Required]
        public decimal CodDist { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Provstamp { get; set; }
        public virtual Prov Prov { get; set; }

        public virtual ICollection<Pad> Pad { get; set; }
    }
}
