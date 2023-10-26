using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Combustivel
    {
        [Key]
        public string Combustivelstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Tipo { get; set; }
    }
}
