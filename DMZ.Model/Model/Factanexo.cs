using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Factanexo
    {
        [Key]
        public string Factanexostamp { get; set; }
        public string Factstamp { get; set; }
        public string Descricao { get; set; }
        public byte[] Anexo { get; set; }
        public virtual Fact Fact { get; set; }
    }
}
