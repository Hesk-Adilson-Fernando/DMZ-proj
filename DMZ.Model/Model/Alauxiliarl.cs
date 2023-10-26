using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Alauxiliarl
    {
        [Key]
        public string Alauxiliarlstamp { get; set; }
        public string Alauxiliarstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual Alauxiliar Alauxiliar { get; set; }
    }
}
