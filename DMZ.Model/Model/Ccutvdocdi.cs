using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMZ.Model.Model
{
    public class Ccutvdocdi
    {
        [Key]
        public string Ccutvdocdistamp { get; set; }
        public string Ccutvstamp { get; set; }
        [Index("IX_X_Ccutvdocdi", 1, IsUnique = true)]
        //[Unique(ErrorMessage = "This already exist !!")]
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public bool Padrao { get; set; }
        public virtual Ccutv Ccutv { get; set; }
    }
}
