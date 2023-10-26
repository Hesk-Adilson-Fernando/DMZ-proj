using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ClContact
    {
        [Key]
        public string ClContactstamp { get; set; }
        public string Clstamp { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        //Representante Legal
        public bool Rep { get; set; }
        // Pessoa de Cobrancas 
        public bool Cob { get; set; }
        //Usado em modulo escolar
        public bool Pai { get; set; }
        // Usado em modulo escolar
        public bool Mae { get; set; }
        // Usado em modulo escolar
        public string Profissao { get; set; }

        public bool Retiraluno { get; set; }
        public virtual Cl Cl { get; set; }
    }
}
