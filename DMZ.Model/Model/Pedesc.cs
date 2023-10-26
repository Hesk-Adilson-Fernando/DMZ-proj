﻿using System;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{

    public  class Pedesc
    {
        [Key]
        public string Pedescstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Valor { get; set; }
        public decimal Tipo { get; set; }
        public decimal Tipodesc { get; set; }
        public string Pestamp { get; set; }
        public DateTime Datain { get; set; }
        public DateTime Datafim { get; set; }
        public bool ExcluiProc { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
