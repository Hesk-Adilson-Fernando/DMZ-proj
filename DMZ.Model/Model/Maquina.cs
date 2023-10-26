
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Maquina
    {
        [Key]
        public string Maquinastamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Numero { get; set; }
        public string IMEI { get; set; }
    }
}
