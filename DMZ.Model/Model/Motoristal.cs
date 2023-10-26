using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Motoristal
    {
        [Key]
        public string Motoristalstamp { get; set; }
        public string Motoristastamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual Motorista Motorista { get; set; }
    }
}
