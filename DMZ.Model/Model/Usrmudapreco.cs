﻿using System;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Usrmudapreco
    {
        [Key]
        public string Usrmudaprecostamp { get; set; }
        public string Usrstamp { get; set; }
        public string Usrvenda { get; set; }
        public string Usrsupervidor { get; set; }
        public string Referenc { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Preco { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Precoalter { get; set; }
        public DateTime Data { get; set; }
        public string Docstamp { get; set; }
        public string Origem { get; set; }
        public virtual Usr Usr { get; set; }
    }
}
