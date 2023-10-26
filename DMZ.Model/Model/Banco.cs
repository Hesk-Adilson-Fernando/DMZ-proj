

using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Banco
    {
        [Key]
        public string Bancostamp { get; set; }
        
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public bool Cx { get; set; }
    }
}
