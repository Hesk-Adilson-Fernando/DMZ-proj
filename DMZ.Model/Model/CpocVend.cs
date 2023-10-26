using System.ComponentModel.DataAnnotations;
using DMZ.Model.Generic;

namespace DMZ.Model.Model
{
    public  class CpocVend
    {
        [Key]
        [StringLength(30)]
        public string Cpocvendstamp { get; set; }

        [StringLength(30)]
        public string Cpocstamp { get; set; }

        public int Tabiva { get; set; }
        public string Taxaiva { get; set; }
        [Required]
        [StringLength(12)]
        public string ValVenda { get; set; }

        [Required]
        [StringLength(12)]
        public string Iva { get; set; }
        public string Desconto { get; set; } //Desconto Comercial 
        public string Descontofin { get; set; } //Desconto Financeiro  
        public bool Nac { get; set; }
        //Conta para cliente extrangeiro ...
        public string ValVendaest { get; set; }
        public string ValVendaoutro { get; set; }
        public virtual Cpoc Cpoc { get; set; }
    }
}
