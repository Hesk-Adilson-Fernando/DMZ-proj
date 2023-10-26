using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Inst
    {
        [Key]
        public string Inststamp { get; set; }
        public string Codesc { get; set; }
        public string Descricao { get; set; }
        [MaxLength(600)]
        public string Obs { get; set; }
        public virtual ICollection<Instunid> Instunid { get; set; }
    }
}
