using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Paramac
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Paramacstamp { get; set; }
        public string AnoLectivo { get; set; }
    }
}
