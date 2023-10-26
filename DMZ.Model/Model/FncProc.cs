using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class FncProc
    {
        [Key]
        public string FncProcstamp { get; set; }
        public string Fncstamp { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Avaliacao { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Criterio { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Grau { get; set; }
        public virtual Fnc Fnc { get; set; }
    }
}
