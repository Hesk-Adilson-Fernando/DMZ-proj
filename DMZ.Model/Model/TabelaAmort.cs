using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class TabelaAmort
    {
        [Key]
        public string TabelaAmortstamp { get; set; }
        [MaxLength(10)]
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        [MaxLength(150)]
        public string Grupo { get; set; }
        [MaxLength(150)]
        public string SubGrupo { get; set; }
        [DecimalPrecision(5, 2,true)] 
        public decimal Perc1 { get; set; }
    }
}
