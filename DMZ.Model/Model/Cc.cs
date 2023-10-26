using System;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Cc
    {
        [Key]
        public string Ccstamp { get; set; }
        public string Origem { get; set; }
        public string Oristamp { get; set; }
        public decimal Nrdoc { get; set; }
        public string No { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public DateTime Vencim { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Debito { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Debitom { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Debitof { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Debitofm { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Credito { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Creditom { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Creditof { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Creditofm { get; set; }
        public string Documento { get; set; }
        public string Moeda { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Saldo { get; set; }
        public decimal Codmov { get; set; }
        public string Factstamp { get; set; }
        public string Rclstamp { get; set; }
        public string Clstamp { get; set; }
        public string Usrstamp { get; set; }
        public string Rdstamp { get; set; }
        public string Ccusto { get; set; }
        public string Numinterno { get; set; }
        public decimal Estabno { get; set; }
        public string Estabnome { get; set; }
        [DecimalPrecision(8, 2, true)]
        public decimal Cambiousd { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Descontofin { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal MDescontofin { get; set; }
        public bool Rcladiant { get; set; }//Recibo de adiantamento
        public string Entidadebanc { get; set; }
        public string Referencia { get; set; }
        public bool Pos { get; set; }//Indica a factura foi feita no pos 
        public virtual Fact Fact { get; set; }

        //public bool Pago { get; set; }
        //[MaxLength(20000)]
        //public string Obsrcc { get; set; }
        //public DateTime Data_limite_pagamento { get; set; }
        //public DateTime Datapagamento { get; set; }
        public virtual RCL Rcl { get; set; }
    }
}
