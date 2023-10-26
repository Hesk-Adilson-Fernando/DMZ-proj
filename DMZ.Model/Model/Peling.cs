﻿using System.ComponentModel.DataAnnotations;
namespace DMZ.Model.Model
{
    public class Peling
    {
        [Key]
        public string Pelingstamp { get; set; }
        public string Lingua { get; set; }
        public string Fala { get; set; }
        public string Leitura { get; set; }
        public string Escrita { get; set; }
        public string Compreecao { get; set; }
        public bool Materna { get; set; }
        public string Pestamp { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
