using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class StCt
    {
         [Key]
        public string StCtstamp { get; set; }
        public string Ststamp { get; set; }
        public string Conta { get; set; }
        public string Descgrupo { get; set; }
        public bool Contacc { get; set; }
        public bool MovIntegra { get; set; }
        public virtual St St { get; set; }
    }

}
