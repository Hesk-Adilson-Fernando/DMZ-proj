using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Condpagl
    {
        [Key]
        public string Condpaglstamp { get; set; }
        public string Condpagstamp { get; set; }
        public decimal Diain { get; set; } //Dias Inicio 
        public decimal Diafim { get; set; } //Dias Termino 
        [DecimalPrecision(5, 2, true)]
        public decimal Percetagem { get; set; } //Dias Termino 
        public virtual Condpag Condpag { get; set; } 
    }
}
