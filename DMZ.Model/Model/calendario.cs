using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class calendario
    {
        [Key]
        public string calendariostamp { get; set; }
        public DateTime date { get; set; }
        public string events { get; set; }
        //public string CLocalStamp { get; set; } = "";
        //public string Ctabela { get; set; }
    }
}
