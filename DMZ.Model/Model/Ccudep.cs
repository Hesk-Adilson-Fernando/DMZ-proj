using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Ccudep
    {
        [Key]
        public string Ccudepstamp { get; set; }
        public string Ccustamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual CCu CCu { get; set; }
    }
}