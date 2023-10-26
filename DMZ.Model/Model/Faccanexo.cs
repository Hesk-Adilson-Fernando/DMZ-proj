using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Faccanexo
    {
        [Key]
        public string Faccanexostamp { get; set; }
        public string Faccstamp { get; set; }
        public string Descricao { get; set; }
        public byte[] Anexo { get; set; }
        public virtual Facc Facc { get; set; }
    }
}
