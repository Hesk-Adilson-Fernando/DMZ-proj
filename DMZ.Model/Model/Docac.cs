using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Docac //Documentos necessario na academia 
    {
        [Key]
        public string Docacstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
