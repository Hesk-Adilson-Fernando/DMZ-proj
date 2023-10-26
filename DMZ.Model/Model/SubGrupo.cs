using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class SubGrupo
    {
        [Key]
        public string SubGrupostamp { get; set; }
        public string Grupostamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public virtual Grupo Grupo { get; set; }
    }
}