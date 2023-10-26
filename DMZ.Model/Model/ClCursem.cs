using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClCursem
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Clcursemstamp { get; set; }
        public string ClCursostamp { get; set; }
        public string Codsem { get; set; }
        public string Sem { get; set; }
        public virtual ClCur ClCurso { get; set; }
        public virtual ICollection<ClCursemdisc> ClCursemdisc { get; set; }
    }
}
