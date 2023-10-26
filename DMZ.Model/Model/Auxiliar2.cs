using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Auxiliar2
    {
        [Key]
        public string Auxiliar2stamp { get; set; }
        public string Auxiliarstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual Auxiliar Auxiliar { get; set; }
    }
}
