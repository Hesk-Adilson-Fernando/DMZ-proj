using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Peaus
    {
        [Key]
        public string Peausstamp { get; set; }
        public string Pestamp { get; set; }
        public  string Descricao { get; set; }
        public  DateTime Datain{ get; set; }
        public  DateTime Datater { get; set; }
        public  bool Processa { get; set; }
        public  bool Cancelada { get; set; }
        public  virtual Pe Pe { get; set; }
    }
}
