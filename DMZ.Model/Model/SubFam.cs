using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class SubFam
    {
        [Key]
        public string Subfamstamp { get; set; }
        public string Familiastamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public bool Pos { get; set; }
        public string Descpos { get; set; }
        public decimal Sequenc { get; set; }
        public virtual Familia Familia { get; set; }
    }
}
