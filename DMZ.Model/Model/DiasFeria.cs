using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class DiasFeria
    {
        [Key]
        public string DiasFeriastamp { get; set; }
        public string Descricao { get; set; }
        public decimal Dias  { get; set; }
        public decimal Ordem { get; set; }
    }
}
