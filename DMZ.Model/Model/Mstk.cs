using System;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public class Mstk
    {
        [Key]
        public string Mstkstamp { get; set; }
        public string Oristamp { get; set; }
        public string Stampcab { get; set; }
        public string Ststamp { get; set; }
        public string Entidadestamp { get; set; }//clstamp,fncstamp,pestamp,entidadestamp,etc
        public string Origem { get; set; }
        public DateTime Data { get; set; }
        public string Tipodoc { get; set; }
        public decimal Nrdoc { get; set; }
        public string Documento { get; set; }
        public decimal Numdoc { get; set; }
        public string Ref { get; set; }
        public string Descricao { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Entrada { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Saida { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Vendido { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Vendidosaida { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Comparado { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Comparadoentrada { get; set; }
        public decimal Reserva { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Reservasaida { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Encomenda { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Encomendaentrada { get; set; }
        public decimal Codarm { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Preco { get; set; }
        public string Moeda { get; set; }
        public decimal Entidade { get; set; }
        public decimal No { get; set; }
        public string Nome { get; set; }
        public DateTime Datahora { get; set; }
        public string Lote { get; set; }
        public decimal Codmovstk { get; set; }
        public string Descmovstk { get; set; }
        public string Numinterno { get; set; }
        
        public string Factstamp { get; set; }
        public string Faccstamp { get; set; }
        public string Distamp { get; set; }
        public string Ivstamp { get; set; }
        public string Factlstamp { get; set; }
        public string Facclstamp { get; set; }
        public string Dilstamp { get; set; }
        public string Ivlstamp { get; set; }
        public string Turno { get; set; }
        public string Vendedor { get; set; }
        public decimal Codvend { get; set; }
        public string Serie { get; set; }
        public bool Ivainc { get; set; }

        public decimal Tabiva { get; set; }
        public decimal Txiva { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Preco2 { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Preco3 { get; set; }
        public DateTime Lotevalid { get; set; }
        public DateTime Lotelimft { get; set; }
        public bool Usalote { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Qttmedida { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Totalmedida { get; set; }
        public string Ccusto { get; set; }
        public string Codccu { get; set; }
        public string Unidade { get; set; }
        public string Armazemstamp { get; set; }
        public string Ccustamp { get; set; }
        public string Usrstamp { get; set; }
        public virtual Factl Factl { get; set; }
        public virtual Dil Dil { get; set; }
        public virtual Faccl Faccl { get; set; }
    }
}
