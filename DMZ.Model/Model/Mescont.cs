using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Mescont
    {
        [Key]
        public string Mescontstamp { get; set; }
        public string Codigo { get; set; }
        public string Nomemes { get; set; }
        public string Mes { get; set; }
    }
}
