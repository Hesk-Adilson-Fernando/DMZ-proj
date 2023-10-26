using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMZ.Model.Model
{
    public class ProcCrt
    {
        [Key]
        public string ProcCrtstamp { get; set; }
        public string Procurmstamp { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Criterio { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Grau { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Avaliacao { get; set; }

        public virtual Procurm Procurm { get; set; }
    }
}
