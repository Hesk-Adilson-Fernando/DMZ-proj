using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DMZ.Model.Model
{
    public class Grupo
    {
        [Key]
        public string Grupostamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public virtual ICollection<SubGrupo> SubGrupo { get; set; }
    }
}
