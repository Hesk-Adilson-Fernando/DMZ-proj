using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Stb
    {
        [Key]
        public string Stbstamp { get; set; }
        public string Ststamp { get; set; }
        [MaxLength(2100)]
        public string Descricao { get; set; }
        public virtual St St { get; set; }
    }
}