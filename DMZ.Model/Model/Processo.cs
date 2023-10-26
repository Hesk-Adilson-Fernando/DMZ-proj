using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Processo
    {
        [Key]
        public string Processostamp { get; set; }
        public decimal Numdoc { get; set; }
        public string Sigla { get; set; }
        public decimal Numero { get; set; }
        public DateTime Data { get; set; }
        public DateTime Dataven { get; set; }
        public string No { get; set; }
        public string Nome { get; set; }
        public string Pestamp { get; set; }
        public decimal Tipo { get; set; }
        public virtual ICollection<Processol> Processol { get; set; }
    }
}
