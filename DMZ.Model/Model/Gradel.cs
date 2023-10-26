using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Gradel
    {
        [Key]
        public string Gradelstamp { get; set; }
        public string Gradestamp { get; set; }
        public string Codetapa { get; set; }//
        public string Etapa { get; set; }//Ordem etapa 
        public string Coddisc { get; set; }
        public string Displina { get; set; }
        public string Ststamp { get; set; }//representa o stamp da disciplina 
        public string Semstamp { get; set; }//Stamp do semestre 
        public string Categoria { get; set; }
        public bool Opcao { get; set; }
        [DecimalPrecision(6, 2, true)]
        public decimal Credac { get; set; }//Credito Academico
        [DecimalPrecision(6, 2, true)]
        public decimal Cargahtotal { get; set; }//Somatorio de teorica e pratica 
        [DecimalPrecision(6, 2, true)]
        public decimal Cargahteorica { get; set; }//Carga Horaria contacto 
        [DecimalPrecision(6, 2, true)]
        public decimal Cargahpratica { get; set; }//Carga Horaria de estudo 
        public bool Prec { get; set; }//Indica se a disciplina tem precedencia 
        public virtual Grade Grade { get; set; }
        public virtual St St { get; set; }
        public virtual Sem Sem { get; set; }
    }
}