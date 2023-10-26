using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Paramemail
    {
        [Key]
        public string Paramemailstamp { get; set; }
        public string Paramstamp { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public decimal Codtipo { get; set; }
        public string Tipo { get; set; }
        public virtual Param Param { get; set; }
    }
}
