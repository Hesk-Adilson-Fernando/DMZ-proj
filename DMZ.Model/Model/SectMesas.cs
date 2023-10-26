using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class SectMesas
    {
        [Key]
        public string Sectmesasstamp { get; set; }
        public string Mesasstamp { get; set; }
        public string Descricao { get; set; }
        public string Sectorstamp { get; set; }
        public virtual Sector Sector { get; set; }
    }
}
