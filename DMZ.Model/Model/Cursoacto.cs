using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Cursoacto
    {
        [Key]
        public string Cursoactostamp { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Anosem { get; set; }
        public string Cursostamp { get; set; }
        public virtual Curso Curso { get; set; }
    }
}