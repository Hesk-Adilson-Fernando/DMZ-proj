using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMZ.Model.Model
{
    public  class TdocPj
    {
        [Key]
        public string Tdocpjstamp { get; set; }
        public decimal Numdoc { get; set; }
        public string Descricao { get; set; }
        [Index(IsUnique = true)]
        public string Sigla { get; set; }
        public bool Defa { get; set; }
        public bool Compra { get; set; } // Permite mostrar buttao compras 
        public bool Venda { get; set; } // Permite mostrar buttao vendas 
        public bool Di { get; set; }// Permite mostrar buttao documentos internos 
    }

}
