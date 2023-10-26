using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Usrcontas
    {
        [Key]
        public string Usrcontasstamp { get; set; }
        public string Usrstamp { get; set; }
        public string Conta { get; set; }
        public string Contasstamp { get; set; }
        public decimal Codtz { get; set; }
        public bool Cx { get; set; }
        public string Descpos { get; set; }
        public virtual Usr Usr { get; set; }
    }
}
