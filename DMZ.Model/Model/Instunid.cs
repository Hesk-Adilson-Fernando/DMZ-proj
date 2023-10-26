using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Instunid
    {
        [Key]
        public string Instunidstamp { get; set; }
        public string Inststamp { get; set; }
        public string Codesc { get; set; }
        public string Codunid { get; set; }
        public string Descricao { get; set; }
        [MaxLength(600)]
        public string Obs { get; set; }
        public virtual Inst Inst { get; set; }
        public virtual ICollection<Instunidl> Instunidl { get; set; }
    }
}
