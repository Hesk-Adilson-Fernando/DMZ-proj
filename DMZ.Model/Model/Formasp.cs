﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{

    public class Formasp
    {
        [Key]
        public string Formaspstamp { get; set; }
        public string Titulo { get; set; }
        public string Numtitulo { get; set; }
        public DateTime Dcheque { get; set; }
        public string Banco { get; set; }
        public string Banco2 { get; set; }
        [Required(ErrorMessage = "A conta tesouraria não pode ser vazio")]
        public string Contatesoura { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "O número da tesouraria não pode ser vazio")]
        public decimal Codtz { get; set; }
        public decimal Codtz2 { get; set; }
        public string Contatesoura2 { get; set; }
        public string Contasstamp2 { get; set; }
        public bool Trf { get; set; }
        public bool Numer { get; set; }
        public bool Tipo { get; set; }
        public bool ObgTitulo { get; set; }
        public string Rclstamp { get; set; }
        public string Oristamp { get; set; }
        public string Factstamp { get; set; }
        public string Faccstamp { get; set; }
        public string Pgfstamp { get; set; }
        public string Perclstamp { get; set; }
        public bool Status { get; set; }
        public string Distamp { get; set; }
        public decimal Cpoc { get; set; }
        public decimal ContaPgc { get; set; }
        public string Origem { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Mvalor { get; set; }
        public decimal Codmovtz { get; set; }
        public string Descmovtz { get; set; }
        public decimal Codmovtz2 { get; set; }
        public string Descmovtz2 { get; set; }
        public string UsrLogin { get; set; }//RECEBE O STAMP DO UTILIZADOR 
        public bool AberturaCaixa { get; set; }
        public decimal No { get; set; }
        public string Nome { get; set; }
        public decimal Numero { get; set; }
        public string Ccusto { get; set; }
        public virtual Fact Fact { get; set; }
        public virtual Facc Facc { get; set; }
        public virtual RCL Rcl { get; set; }
        public virtual Pgf Pgf { get; set; }
        public virtual Di Di { get; set; }
        public string Contasstamp { get; set; }
        public virtual Percl Percl { get; set; }
        public string Ccustamp { get; set; }
        public string Moeda { get; set; }
        [DecimalPrecision(8, 2, true)]
        public decimal Cambiousd { get; set; }
        public virtual ICollection<Mvt> Mvt { get; set; }

    }
}
