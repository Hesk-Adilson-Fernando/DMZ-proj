﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClBolsa
    {
        [Key]
        public string ClBolsastamp { get; set; }
        public string Clstamp { get; set; }
        public string Instituicao { get; set; }
        public string Tipobolsa { get; set; }
        public DateTime Datain { get; set; }
        public DateTime Datatermino { get; set; }
        public string Anolectivo { get; set; }
        public decimal Valor { get; set; }
        public decimal Perc { get; set; }
        [MaxLength(600)]
        public string Obs { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
