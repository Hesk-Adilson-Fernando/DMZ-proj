using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Meses
    {
        [Key]
        public string Mesesstamp { get; set; }
        public string Descricao { get; set; }
        public decimal Codigo { get; set; }
        public string Tipo { get; set; }
        public decimal Codtipo { get; set; }
    }
}
