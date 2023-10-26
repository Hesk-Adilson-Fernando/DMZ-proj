using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class RltCc
    {
        [Key]
        public string RltCcstamp { get; set; }
        public string Ccusto { get; set; }
        public string Codccu { get; set; }
        public bool Estado { get; set; }
        public string Rltstamp { get; set; }
        public virtual Rlt Rlt { get; set; }
    }
}
