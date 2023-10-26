using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClLing
    {
        [Key]
        public string ClLingstamp { get; set; }
        public string Lingua { get; set; }
        public string Fala { get; set; }
        public string Leitura { get; set; }
        public string Escrita { get; set; }
        public string Compreecao { get; set; }
        public bool Materna { get; set; }
        public string Clstamp { get; set; }
        public virtual Cl Cl { get; set; }
    }
}