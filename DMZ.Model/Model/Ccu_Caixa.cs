

using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Ccu_Caixa
    {
        [Key]
        public string Ccu_Caixastamp { get; set; }
        public string Ccustamp { get; set; }
        public decimal Codtz { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public bool Defeito { get; set; }
        public bool Cx { get; set; }
        public string Contasstamp { get; set; }
        public string Descpos { get; set; }
        public virtual CCu CCu { get; set; }
    }
}
