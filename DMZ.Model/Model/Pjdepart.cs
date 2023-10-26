using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Pjdepart
    {
        [Key] 
        public string Pjdepartstamp { get; set; }
        public string Pjstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        [MaxLength(600)]
        public string Resp { get; set; }
        public virtual Pj Pj { get; set; }
    }
}
