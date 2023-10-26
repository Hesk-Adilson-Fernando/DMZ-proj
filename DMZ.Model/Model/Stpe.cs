using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Stpe
    {
        [Key]
        public string Stpestamp { get; set; }
        public string Ststamp { get; set; }
        public string Pestamp { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public virtual St St { get; set; }
    }
}