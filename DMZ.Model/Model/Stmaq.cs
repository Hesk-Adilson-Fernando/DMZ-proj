﻿using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Stmaq
    {
        [Key]
        public string Stmaqstamp { get; set; }
        public string Ststamp { get; set; }
        public string Maquinastamp { get; set; }
        public string Descricao { get; set; }
        public string IMEI { get; set; }
        public virtual St St { get; set; }
    }
}