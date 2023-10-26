using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public  class Dil
    {
        [Key]
        public string Dilstamp { get; set; }
        public string Distamp { get; set; }
        public string Ststamp { get; set; }
        public string Entidadestamp { get; set; }//clstamp,entidadestamp,fncstamp,pestamp
        public decimal Numdoc { get; set; }
        public string Sigla { get; set; }
        public string Ref { get; set; }
        [Column("Descricao", TypeName="nvarchar(max)")]
        public string Descricao { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Quant { get; set; }
        public string Unidade { get; set; }
        public decimal Armazem { get; set; }
        public string Descarm { get; set; }
        public decimal Armazem2 { get; set; }
        public string Descarm2 { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Preco { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Mpreco { get; set; }
        public string Lote { get; set; }
        public decimal Tabiva { get; set; }
        [DecimalPrecision(5, 2,true)] 
        public decimal Txiva { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Valival { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Mvalival { get; set; }
        public bool Ivainc { get; set; }
        public decimal Perdesc { get; set; }
        [DecimalPrecision(16, 2,true)]
        public decimal Descontol { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Mdescontol { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Subtotall { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Msubtotall { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Totall { get; set; }
        [DecimalPrecision(18, 4, true)]
        public decimal Mtotall { get; set; }
        public bool Status { get; set; }
        public bool Usadesign { get; set; }
        public bool Servico { get; set; }
        public bool Nmovstk { get; set; }
        public string Remotestamp { get; set; }
        public string oristamp { get; set; }
        public bool Tit { get; set; }
        public decimal Ordem { get; set; }
        public bool Stkprod { get; set; }
        public string Titstamp { get; set; }
        public bool Usaserie { get; set; }
        public string Serie { get; set; }
        public decimal contatz { get; set; }
        public bool Composto { get; set; }
        public bool Usalote { get; set; }
        public string Acordo { get; set; }
        public bool Processado { get; set; }
        //public bool Stactivo { get; set; }//Indica se o artigo em activo segundo contabil.
         public bool Activo { get; set; }//Indica se o artigo em activo segundo contabil.
        [MaxLength(2000)]
        public string Obs { get; set; }
        public decimal Cpoc { get; set; }
        public decimal Cpoo { get; set; }
        public bool Gasoleo { get; set; } 
        [DecimalPrecision(10, 3, true)]
        public decimal Cambiousd { get; set; }
        public string Moeda { get; set; } 
        public string Moeda2 { get; set; } 
        public bool LineAnulado { get; set; }
        public string Ccusto { get; set; }
        public string Codccu { get; set; }
        public string Armazemstamp2 { get; set; }
        public string Armazemstamp { get; set; }
        public string Refornec { get; set; }//Referencia do fornecedor 
        public bool Usaquant2 { get; set; }//Utiliza quantidade 2 nas vendas casos de bedidas a pressao 
        [DecimalPrecision(18, 4, true)]
        public decimal Quant2 { get; set; }
        public virtual Di Di { get; set; }     
        public virtual ICollection<Mstk> Mstk { get; set; }
        public virtual ICollection<Dill> Dill { get; set; }
    }
}
