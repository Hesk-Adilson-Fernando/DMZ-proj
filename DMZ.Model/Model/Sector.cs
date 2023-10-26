using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Sector
    {
        [Key]
        public string Sectorstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<SectMesas> Mesas { get; set; }
    }
}
