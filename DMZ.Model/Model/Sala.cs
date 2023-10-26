using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Sala
    {
        [Key]
        public string Salastamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Capacidade { get; set; }
    }
}
