using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClCt
    {
        [Key]
        public string ClCtstamp { get; set; }
        public string Clstamp { get; set; }
        public string Conta { get; set; }
        public string Descgrupo { get; set; }
        public bool Contacc { get; set; }
        public bool MovIntegra { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
