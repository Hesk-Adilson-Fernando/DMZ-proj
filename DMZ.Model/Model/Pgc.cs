using System;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public  class Pgc
    {
        [Key]
        public string Pgcstamp { get; set; }
        public string Conta { get; set; }
        public string Descricao { get; set; }
        public string Ncont { get; set; }
        public bool Integracao { get; set; }
        public string Contaiva { get; set; }
        public decimal Codiva { get; set; }
        public decimal Codiva2 { get; set; }

        [DecimalPrecision(16, 2,true)]
        public decimal Taxaiva { get; set; }
        public DateTime Udata { get; set; }
        public string Obs { get; set; }
        public string Ppconta { get; set; }
        public decimal Ano { get; set; }
        public string Codis { get; set; }
        public bool Criadanoano { get; set; }
        public bool Dedutivel { get; set; }
        public bool Liquidado { get; set; }
        public string Oristamp { get; set; }
        public bool Moviva { get; set; }
        public bool Activo { get; set; }
        public decimal Numero { get; set; }//Indica se é usado no mapa balanco ou nao e a sua posicao 
    }
}
