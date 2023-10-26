using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Turmadisc
    {
        [Key]
        public string Turmadiscstamp { get; set; }
        public string Turmastamp { get; set; }
        public string Ststamp { get; set; }
        public string Referenc { get; set; }
        public string Disciplina { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual ICollection<Turmadiscp> Turmadiscp { get; set; }//Professores 
    }
}