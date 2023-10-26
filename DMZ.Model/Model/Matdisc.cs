using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Matdisc
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Matdiscstamp { get; set; }
        public string Matstamp { get; set; }

        public string Coddisc { get; set; }
        public string Disc { get; set; }

    }
}
