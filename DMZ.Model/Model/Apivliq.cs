using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Apivliq
    {
        [Key]
        public string Apivliqlstamp { get; set; }
        public string Conta { get; set; }
        public string Descricao { get; set; }
        public string Apparamstamp { get; set; }
        public virtual Apparam Apparam { get; set; }
    }
}
