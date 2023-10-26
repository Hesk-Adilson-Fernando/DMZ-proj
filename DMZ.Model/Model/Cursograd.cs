using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Cursograd
    {
        [Key]
        public string Cursogradstamp { get; set; }
        public string Cursostamp { get; set; }
        public string Gradestamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Principal { get; set; }
        public virtual Curso Curso { get; set; }
    }
}