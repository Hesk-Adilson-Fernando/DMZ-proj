using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Faccprest
    {
        [Key]
        public string Faccpreststamp { get; set; }
        public string Faccstamp { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public decimal Perc { get; set; }
        public decimal Valor { get; set; }
        public string Obs { get; set; }
        public bool Status { get; set; }

        public virtual Facc Facc { get; set; }
    }
}
