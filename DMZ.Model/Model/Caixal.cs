using System;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Caixal
    {
        [Key]
        public string Caixalstamp { get; set; }
        public string Caixastamp { get; set; }
        public DateTime Data { get; set; }
        public decimal Codtz { get; set; }
        public string Contatesoura { get; set; }
        public string Qmf { get; set; }
        public DateTime Qmfdathora { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Entrada { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Saida { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Saldo { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Lancado { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal TotalDefice { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Campo1 { get; set; }
       [DecimalPrecision(16, 2,true)]
        public decimal Campo2 { get; set; }
        public string Campo3 { get; set; }
        [MaxLength(600)]
        public string Obs { get; set; }
        public string Contasstamp { get; set; }
        public string MobileUnicNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Corredor { get; set; }
        public string Corredorstamp { get; set; }
        public string Carreirastamp { get; set; }
        public string Carreira { get; set; }
        public string Matricula { get; set; }
        public string Viaturastamp { get; set; }
        public string Mobileserial { get; set; }
        public string Turno { get; set; }
        public string Turnostamp { get; set; }
        public virtual Caixa Caixa { get; set; }
    }

}
