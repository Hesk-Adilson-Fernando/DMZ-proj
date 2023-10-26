using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pad
    {
        public decimal Codpad { get; set; }
        public decimal Coddist { get; set; }
        public string Descricao { get; set; }
        public string Diststamp { get; set; }
        [Key]
        public string Padstamp { get; set; }

        public virtual Dist Dist { get; set; }
    }
}
