using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class StVtman
    {
        [Key]
        public string StVtmanstamp { get; set; }
        public string Matricula { get; set; }
        public decimal Valparam { get; set; }
        public decimal Valkm { get; set; }
        public decimal Diferenca { get; set; }
        public bool Feito { get; set; }
        public string Distamp { get; set; }
        public virtual St St { get; set; }
    }
}
