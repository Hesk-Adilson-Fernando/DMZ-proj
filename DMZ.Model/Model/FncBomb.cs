using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class FncBomb
    {
        [Key]
        public string Fncbombstamp { get; set; }
        public string Fncstamp { get; set; }
        public string No { get; set; }
        public string Descricao { get; set; }
        public virtual Fnc Fnc { get; set; }

    }
}
