
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pecont
    {
        [Key]
        public string Pecontstamp { get; set; }
        public string Contacto { get; set; }
        public bool Email { get; set; }
        public string Pestamp { get; set; }
        public bool Padrao { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
