using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Transpvt
    {
        [Key]
        public string Transpvtstamp { get; set; }
        public string Transpstamp { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public string Motorista { get; set; }
        public virtual Transp Transp { get; set; }
    }
}
