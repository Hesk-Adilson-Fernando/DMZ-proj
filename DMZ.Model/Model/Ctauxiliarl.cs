using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Ctauxiliarl
    {
        [Key]
        public string Ctauxiliarlstamp { get; set; }
        public string Ctauxiliarstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual Ctauxiliar Ctauxiliar { get; set; }
    }
}
