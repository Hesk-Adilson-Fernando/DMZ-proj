using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Dianexo
    {
        [Key]
        public string Dianexostamp { get; set; }
        public string Distamp { get; set; }
        public string Descricao { get; set; }
        public byte[] Anexo { get; set; }
        public virtual Di Di { get; set; }
    }
}
