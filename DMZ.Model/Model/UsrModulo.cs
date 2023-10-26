using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class UsrModulo
    {
        [Key]
        public string Usrmodulostamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Usrstamp { get; set; }         
        public bool Activo { get; set; }
        public virtual Usr Usr { get; set; }
        public virtual ICollection<Usracessos> Usracessgrupo { get; set; }
    }
}
