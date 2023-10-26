using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Horariol
    {
        [Key]
        public string Horariolstamp { get; set; }
        public string Horariostamp { get; set; }
        public string Descricao { get; set; }
        public string Hora { get; set; }
        public string Segunda { get; set; }
        public string Terca { get; set; }
        public string Quarta { get; set; }
        public string Quinta { get; set; }
        public string Sexta { get; set; }
        public string Sabado { get; set; }
        public string Domingo { get; set; }
        public virtual Horario Horario { get; set; }
    }
}