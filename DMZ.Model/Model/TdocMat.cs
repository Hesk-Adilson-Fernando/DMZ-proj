using DMZ.Model.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.Model.Model
{
    public class TdocMat
    {
        [Key]
        public string TdocMatstamp { get; set; }
        public decimal Numdoc { get; set; }
        public string Descricao { get; set; }
        [Index("IX_X_Tdoc", 1, IsUnique = true)]
        public string Sigla { get; set; }
        public bool Defa { get; set; }
        public bool Inscricao { get; set; } = false;
        public bool Matricula { get; set; } = false;
    }
}
