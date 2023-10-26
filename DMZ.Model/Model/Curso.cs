using DMZ.Model.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Curso
    {
        [Key]
        public string Cursostamp { get; set; }
        public string Codcurso { get; set; }
        public string Desccurso { get; set; }
        public decimal Tipo { get; set; } //1-Normal, 2- Modular, 3- ETC
        public string Status { get; set; }
        public string Nivel { get; set; }
        public string Nivelstamp { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Cargahora { get; set; }//Carga Horaria 
        public string Cursoeq { get; set; } //Curso Equivalente 
        [DecimalPrecision(16, 2, true)]
        public decimal Duracao { get; set; } //Duracao da Hora 
        public string Codmec { get; set; } //Codigo do Ministerio da Educacao 
        public string Habmec { get; set; } //Habilitacoes do Ministerio da Educacao 
        [MaxLength(2100)]
        public string Obs { get; set; }
        public byte[] Imagem { get; set; }
        public string CCusto { get; set; }
        public string Ccustamp { get; set; }
        public string Ccudepstamp { get; set; }
        public string Departamento { get; set; }
        public string Pestamp { get; set; }
        public string Director { get; set; }
        public virtual ICollection<Cursoacto> Cursoacto { get; set; }
        public virtual ICollection<Cursodoc> Cursodoc { get; set; }
        public virtual ICollection<Cursograd> Cursograd { get; set; }
        public virtual ICollection<Turma> Turma { get; set; }
    }
}
