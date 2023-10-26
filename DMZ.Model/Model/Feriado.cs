using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Feriado
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Feriadostamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool Academico { get; set; }
        public bool Biblioteca { get; set; }
        public bool Administrativo { get; set; }
        public bool Nacional { get; set; }
        public virtual ICollection<Feriadol> Feriadol { get; set; }
    }
}
