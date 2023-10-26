using System;
using System.ComponentModel.DataAnnotations;


namespace DMZ.Model.Model
{
    public class Paises
    {
        [Key]
        public string Paisestamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
