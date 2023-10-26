using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pjdoc
    {
        [Key] 
        public string Pjdocstamp { get; set; }
        public string Pjstamp { get; set; }
        [MaxLength(600)]
        public string Descricao { get; set; }
        public byte[] Anexo { get; set; }
        public bool Doclc { get; set; }
        public virtual Pj Pj { get; set; }
    }
}
