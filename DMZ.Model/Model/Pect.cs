using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
   public class Pect
    {
        [Key]
        public string Pectstamp { get; set; }
        public string Pestamp { get; set; }
        public string Conta { get; set; }
        public string Descgrupo { get; set; }
        public bool Contacc { get; set; }
        public bool MovIntegra { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
