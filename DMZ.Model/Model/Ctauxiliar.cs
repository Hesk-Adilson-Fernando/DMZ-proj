using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class Ctauxiliar
    {
        [Key]
        public string Ctauxiliarstamp { get; set; }
        [Required]
        public decimal Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public decimal Tabela { get; set; }
        public string Desctabela { get; set; }
        public bool Padrao { get; set; }
        public string Obs { get; set; }
        public virtual ICollection<Ctauxiliarl> Ctauxiliarl { get; set; }
    }
}
