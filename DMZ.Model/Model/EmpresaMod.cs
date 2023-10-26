using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class EmpresaMod
    {
        [Key]
        public string EmpresaModstamp { get; set; }
        public string Empresastamp { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public DateTime Validade { get; set; }
        public bool Trial { get; set; } = false;
        public string Obs { get; set; }
        public virtual Empresa  Empresa { get; set; }
    }
}
