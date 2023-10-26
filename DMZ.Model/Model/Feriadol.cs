using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Feriadol
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Feriadolstamp { get; set; }
        public string Feriadostamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual Feriado Feriado { get; set; }
    }
}
