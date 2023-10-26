using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Imbauxiliarl
    {
        [Key]
        public string Imbauxiliarlstamp { get; set; }
        public string Imbauxiliarstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual Imbauxiliar Imbauxiliar { get; set; }
    }
}
