using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Diariodoc
    {
        [Key]
        public string Diariodocstamp { get; set; }
        public string Diariostamp { get; set; }
        public decimal Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Padrao { get; set; }
        public virtual Diario Diario { get; set; }
    }
}
