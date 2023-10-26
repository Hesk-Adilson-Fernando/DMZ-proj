﻿using DMZ.Model.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class StDrp
    {
        [Key]
        public string StDrpstamp { get; set; }
        public string Ststamp { get; set; }
        public DateTime Data { get; set; }
        [DecimalPrecision(20, 2,true)]
        public decimal Valdepact { get; set; } //valor depreciável actual 
        [DecimalPrecision(20, 2,true)]
        public decimal Valdep { get; set; }//Valor depreciado 
        [DecimalPrecision(5, 2,true)]
        public decimal TaxaDeprec { get; set; }//Taxa depreciavel 

        [DecimalPrecision(20, 2,true)]
        public decimal Valdepnact { get; set; } //valor depreciável nao actualizado  
        //public decimal VDeprAcumulada { get; set; }
        //public string TipoMov { get; set; }
        //public decimal TotalLiquid { get; set; }
        public virtual St2 St2 { get; set; }
    }
}
