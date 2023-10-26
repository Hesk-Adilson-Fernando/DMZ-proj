using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class ClContas
    {
        [Key]
        public string ClContasstamp { get; set; }
        public string Clstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Moeda { get; set; }
        [DecimalPrecision(16, 0,true)]
        public decimal Numero { get; set; }
        public string Banco { get; set; }
        public string Nib { get; set; }
        public string Swift { get; set; }
        public string Iban { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
