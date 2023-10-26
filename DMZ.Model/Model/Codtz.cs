using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Codtz
    {
        [Key]
        public string Codtzstamp { get; set; }
        [Required]
        public decimal Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
