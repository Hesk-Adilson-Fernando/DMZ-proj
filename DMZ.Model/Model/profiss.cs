using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Profiss
    {
        [Key]
        [StringLength(30)]
        public string Profissstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
