using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Dc
    {
        [Key]
        public string Dcstamp { get; set; }
        public decimal Docno { get; set; }
        public string Docnome { get; set; }
        public string Abrv { get; set; }
        public bool Pedeval { get; set; }
        public bool Arredonda { get; set; }
        public string Olcodigo { get; set; }
        public bool Nvaimapa { get; set; }
        public string Oldesc { get; set; }
        public bool Lancaol { get; set; }
        public bool Naolancapla { get; set; }
        public bool Oltrfa { get; set; }
        public bool Introol { get; set; }
        public bool Ollinhas { get; set; }
        public bool Automl { get; set; }
        public string Qmc { get; set; }
        public DateTime Qmcdathora { get; set; }
        public string Qma { get; set; }
        public DateTime Qmadathora { get; set; }
        public bool Apuraiva { get; set; }
        public bool Apurares { get; set; }

        public virtual ICollection<Dcli> Dcli { get; set; }
    }
}
