using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClFam
    {
        [Key]
        public string ClFamstamp { get; set; }
        public string Clstamp { get; set; }
        public string Nome { get; set; }
        public string Grau { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
