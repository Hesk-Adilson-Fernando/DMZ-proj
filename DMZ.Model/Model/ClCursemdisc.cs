using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClCursemdisc
    {
        [Key]
        public string ClCursemdiscstamp { get; set; }
        public string Coddisc { get; set; }
        public string Disc { get; set; }
        public decimal Valor { get; set; }
        public decimal Cargah { get; set; }
        public bool Prec { get; set; }
    }
}
