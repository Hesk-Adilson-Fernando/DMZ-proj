using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Pecontra
    {
        [Key]
        public string Pecontrastamp { get; set; }
        public string Pestamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Tipo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public bool Estado { get; set; }//Indica se esta fechado ou aberto
        public byte[] Anexo { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
