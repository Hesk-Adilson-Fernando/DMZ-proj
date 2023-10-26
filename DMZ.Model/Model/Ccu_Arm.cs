

using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Ccu_Arm
    {
        [Key]
        public string Ccu_Armstamp { get; set; }
        public string Ccustamp { get; set; }
        public decimal Codarm { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public bool Defeito { get; set; }
        public string Armazemstamp { get; set; }
        public virtual CCu CCu { get; set; }
    }
}
