using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pedisc
    {
        [Key]
        public string Pediscstamp { get; set; }
        public string Disciplina { get; set; }
        public string Sigla { get; set; }
        public string Pestamp { get; set; }
        public string Ststamp { get; set; }
        public virtual Pe Pe { get; set; }
    }
}