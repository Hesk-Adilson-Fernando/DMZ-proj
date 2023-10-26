using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Alauxiliar
    {
        [Key]
        public string Alauxiliarstamp { get; set; }
        [Required]
        public decimal Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public string Obs { get; set; }
        [Required]
        public bool Padrao { get; set; }
        public decimal Tabela { get; set; }
        public string Desctabela { get; set; }
        public virtual ICollection<Alauxiliarl> Alauxiliarl { get; set; }
    }
}
