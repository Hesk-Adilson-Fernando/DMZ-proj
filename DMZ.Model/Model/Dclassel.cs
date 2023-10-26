using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Dclassel
    {
        [Key]
        public string Dclasselstamp { get; set; }
        public string Dclassestamp { get; set; }
        public string Turmastamp { get; set; }
        public string Turma { get; set; }
        public string Cursostamp { get; set; }
        public string Curso { get; set; }
        public virtual Dclasse Dclasse { get; set; }
    }
}