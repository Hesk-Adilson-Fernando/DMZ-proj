using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class Aulino
    {
        [Key]
        public string Aulinostamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Aulinol> Aulinol { get; set; }
    }
}
