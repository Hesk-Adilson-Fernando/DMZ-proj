using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class RltCond
    {
        [Key]
        public string RltCondstamp { get; set; }
        public string LabelText { get; set; }
        [MaxLength(1200)]
        public string SqlComandText { get; set; }
        public decimal Tipocontrol { get; set; }
        public string Filtrostring { get; set; }
    }
}
