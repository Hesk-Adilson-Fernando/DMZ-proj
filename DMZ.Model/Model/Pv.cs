using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pv
    {
        [Key]
        public string Pvstamp { get; set; }

        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public string Cx { get; set; }
        public decimal CodCaixa { get; set; }
    }
}
