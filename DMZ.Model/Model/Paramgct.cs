using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Paramgct
    {
        [Key]
        public string Paramgctstamp { get; set; }
        public string Paramstamp { get; set; }
        public string Grupo { get; set; }
        public string Descricao { get; set; }
        public string Mascara { get; set; }
        public bool Padrao { get; set; }
        public decimal Codtipo { get; set; }
        public string Tipo { get; set; }
        public virtual Param Param { get; set; }
    }
}
