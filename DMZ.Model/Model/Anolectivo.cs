﻿

using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class AnoLectivo
    {
        [Key]
        public string AnoLectivostamp { get; set; }
        public string Codigo { get; set; }
        public decimal Ano { get; set; }
        public string Descricao { get; set; }
    }
}
