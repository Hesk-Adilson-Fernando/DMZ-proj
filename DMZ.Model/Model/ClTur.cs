﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClTur
    {
        [Key]
        public string ClTurstamp { get; set; }
        public string Clstamp { get; set; }
        public string Codtur { get; set; }
        public string Turma { get; set; }
        public string Codcurso { get; set; }
        public string Curso { get; set; }
        public string Anolect { get; set; }
        public string Sala { get; set; }
        public decimal Codsala { get; set; }
        public string Matricula { get; set; }
        public DateTime Datamat { get; set; }
        public string Turno { get; set; }
        public string Periodo { get; set; }
        public string Localmat { get; set; }
        public virtual Cl Cl { get; set; }

    }
}
