

using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClFilial
    {
        [Key]
        public string ClFilialstamp { get; set; }
        public string Clstamp { get; set; }
        public string Oristamp { get; set; }
        public string Descricao { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
