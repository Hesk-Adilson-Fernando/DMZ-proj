using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClCur
    {
        [Key]
        [ScaffoldColumn(false)]
        public string ClCurstamp { get; set; }
        public string Clstamp { get; set; }
        public string Curso { get; set; }
        public string Codcurso { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public bool Concluido { get; set; }
        public virtual Cl Cl { get; set; }
        public virtual ICollection<ClCursem> ClCursol { get; set; }
    }
}
