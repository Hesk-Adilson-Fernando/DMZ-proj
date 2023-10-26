using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Familiacarl
    {
        [Key]
        public string Familiacarlstamp { get; set; }
        public string Familiacarstamp { get; set; }
        public string Ststamp { get; set; }
        public string Descviatura { get; set; }
        public string Matricula { get; set; }
        public virtual Familiacar Familiacar { get; set; }
    }
}