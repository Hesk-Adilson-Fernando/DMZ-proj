using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class PeForm
    {
        [Key]
        [StringLength(30)]
        public string Peformstamp { get; set; }
        public string Curso { get; set; }
        public string Tipo { get; set; }
        public string Instituicao { get; set; }
        public string Nivel { get; set; }
        public DateTime DataIn { get; set; }
        public DateTime Datafim { get; set; }
        public string Duracao { get; set; }
        public string Pestamp { get; set; }
        public string Codpais { get; set; }
        public string Pais { get; set; }
        public string Anofreq { get; set; }
        public virtual Pe Pe { get; set; }
    }
}
