using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Dcli
    {
        [Key]
        public string Dclistamp { get; set; }
        public string dcstamp { get; set; }
        public string conta { get; set; }
        public string rubrica { get; set; }
        public bool deb { get; set; }
        public decimal valor { get; set; }
        [DecimalPrecision(16, 6, true)]
        public decimal factor { get; set; }
        public decimal evalor { get; set; }
        public decimal lordem { get; set; }
        public bool lbanco { get; set; }
        public string cct { get; set; }
        public string ncusto { get; set; }
        public string oldesc { get; set; }
        public decimal docno { get; set; }
        public string sgrupo { get; set; }
        public string grupo { get; set; }
        public string olcodigo { get; set; }

        public virtual Dc dc { get; set; }
    }
}
