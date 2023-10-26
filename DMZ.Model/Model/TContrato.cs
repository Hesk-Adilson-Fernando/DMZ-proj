using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class TContrato
    {
        [Key]
        public string TContratostamp { get; set; }
        public string Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
        public decimal Tipo { get; set; }
    }
}
