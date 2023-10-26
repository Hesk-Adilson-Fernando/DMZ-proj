using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class PjAudit
    {
        [Key]
        public string Pjauditstamp { get; set; }
        public string Pjstamp { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public decimal Comprado { get; set; }
        public decimal Vendido { get; set; }
        public decimal Interno { get; set; }
        public string Login { get; set; }
        public virtual Pj Pj { get; set; }
    }
}
