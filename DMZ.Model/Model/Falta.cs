using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class Falta
    {
        [Key]
        public string Faltastamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public bool DescontaSubAlimenta { get; set; }
        public bool DescontaSubPorTurno { get; set; }
    }
}
