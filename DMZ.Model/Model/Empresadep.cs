using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Empresadep
    {
        [Key]
        public string Empresadepstamp { get; set; }
        public string Empresastamp { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public string Obs { get; set; }
        public virtual Empresa  Empresa { get; set; }
    }
}
