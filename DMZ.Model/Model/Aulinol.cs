using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Aulinol
    {
        [Key]
        public string Aulinolstamp { get; set; }
        public string Aulinostamp { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public virtual Aulino Aulino  { get; set; }
    }
}