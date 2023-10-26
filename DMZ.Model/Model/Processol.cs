using System;
using System.ComponentModel.DataAnnotations;


namespace DMZ.Model.Model
{
    public class Processol
    {
        [Key]
        public string Processolstamp { get; set; }
        public string Processostamp { get; set; }
        public string Ref { get; set; }
        public string Descricao { get; set; }
        public DateTime Datain { get; set; }
        public DateTime Datafim { get; set; }
        public decimal Dias { get; set; }
        public virtual Processo Processo { get; set; }
    }
}
