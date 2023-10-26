using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pefam
    {
        [Key]
        public string Pefamstamp { get; set; }
        public string Nome { get; set; }
        public string Grau { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }
        public string Obs { get; set; }
        public string Pestamp { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
