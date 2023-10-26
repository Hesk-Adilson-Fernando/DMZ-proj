using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class ClDoenca
    {
        [Key]
        [ScaffoldColumn(false)]
        public string ClDoencastamp { get; set; }
        public string Clstamp { get; set; }
        public string Doenca { get; set; }
        public string Coddoenca { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public bool Cronica { get; set; }
        [MaxLength(650)]
        public string Tratamento { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
