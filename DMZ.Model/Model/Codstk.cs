using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Codstk
    {
        [Key]
        public string Codstkstamp { get; set; }
        [Required]
        public decimal Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
