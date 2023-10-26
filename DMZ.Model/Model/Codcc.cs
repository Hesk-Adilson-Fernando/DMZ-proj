using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Codcc
    {
        [Key]
        public string Codccstamp { get; set; }
        [Required]
        public decimal Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
