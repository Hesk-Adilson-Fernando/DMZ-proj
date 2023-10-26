using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Turmadiscp
    {
        [Key]
        public string Turmadiscpstamp { get; set; }
        public string Turmadiscstamp { get; set; }
        public string Pestamp { get; set; }
        public string Ststamp { get; set; }
        public string Nome { get; set; }
        public virtual Turmadisc Turmadisc { get; set; }
    }
}