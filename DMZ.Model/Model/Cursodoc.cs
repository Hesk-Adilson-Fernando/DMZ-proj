using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Cursodoc
    {
        [Key]
        public string Cursodocstamp { get; set; }
        public string Cursostamp { get; set; }
        public string Documento { get; set; }
        public byte[] Anexo { get; set; }
        public virtual Curso Curso { get; set; }
    }
}