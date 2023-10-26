using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Familiacar
    {
        [Key]
        public string Familiacarstamp { get; set; }
        public string Familiastamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual Familia Familia { get; set; }
        public virtual ICollection<Familiacarl> Familiacarl { get; set; }//Viaturas Associadas 
    }
}