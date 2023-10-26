using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
   public class Status
    {
        [Key]
        public string Statustamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Activo { get; set; }
    }
}
