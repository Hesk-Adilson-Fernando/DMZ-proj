using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Rltusr
    {
        [Key]
        public string Rltusrstamp { get; set; }
        public string Login { get; set; }
        public string Descricao { get; set; }
        public string Rltstamp { get; set; }
        public bool Status { get; set; }
        public virtual Rlt Rlt { get; set; }
    }
}
