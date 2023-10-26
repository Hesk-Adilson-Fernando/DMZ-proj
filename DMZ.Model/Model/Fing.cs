using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class Fing //Formas de Ingresso 
    {
        [Key]
        public string Fingstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
