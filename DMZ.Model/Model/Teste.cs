using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class Teste
    {
        [Key]
        public string Testestamp { get; set; }
        public string descricao { get; set; }
    }
}
