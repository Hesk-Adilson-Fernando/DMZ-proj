using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMZ.Model.Model
{
    public class Ccutvdoc
    {
        [Key]
        public string Ccutvdocstamp { get; set; }
        public string Ccutvstamp { get; set; }
        [Index("IX_X_Ccutvdoc", 1, IsUnique = true)]
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public bool Padrao { get; set; }
        public virtual Ccutv Ccutv { get; set; }
    }
}
