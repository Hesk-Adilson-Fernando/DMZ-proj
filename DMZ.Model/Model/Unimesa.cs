using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Unimesa//Uniao de Mesas 
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Unimesastamp { get; set; }
        public string Clstamp { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Unimesal> Unimesal { get; set; }
    }
}
