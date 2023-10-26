using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pjclpe
    {
        [Key] 
        public string Pjclpestamp { get; set; }
        public string Pjstamp { get; set; }
        public string No { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public virtual Pj Pj { get; set; }
        
    }
}
