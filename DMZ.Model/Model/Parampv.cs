﻿using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Parampv
    {
        [Key]
        public string Parampvstamp { get; set; }
        public string Paramstamp { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Valor { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Factor { get; set; }
        public virtual Param Param { get; set; }
    }
}
