using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class Pefunc
    {
        [Key]
        [StringLength(30)]
        public string Pefuncstamp { get; set; }
        public string Funcao { get; set; }
        public string Tipo { get; set; }
        public string Local { get; set; }
        public DateTime DataIn { get; set; }
        public DateTime Datafim { get; set; }
        public string Pestamp { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
