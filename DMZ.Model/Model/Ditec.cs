using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Ditec
    {
        [Key]
        public string Ditecstamp { get; set; }
        public string Distamp { get; set; }
        public string No { get; set; }
        public string Nome { get; set; }
        [MaxLength(300)]
        public string Funcao { get; set; }
        public bool Chefe { get; set; }
        public virtual Di Di  { get; set; }
    }
}
