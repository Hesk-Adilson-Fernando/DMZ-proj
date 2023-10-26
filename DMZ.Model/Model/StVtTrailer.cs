using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class StVtTrailer
    {
        [Key]
        public string StVtTrailerstamp { get; set; }
        public string Ststamp { get; set; }
        public string Matricula { get; set; }
        public string Obs { get; set; }
        public virtual St St { get; set; }
    }
}
