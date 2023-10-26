using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Motorista
    {
        [Key]
        public string Motoristastamp { get; set; }
        public decimal No { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Motoristal> Motoristal  { get; set; }
    }
}
