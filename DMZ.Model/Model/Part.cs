﻿using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Part
    {
        [Key]
        public string Partstamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Padrao { get; set; }
    }
}
