using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Armazem
    {
        [Key]
        public string Armazemstamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Obs { get; set; }
        public bool Padrao { get; set; }
        public bool Sector { get; set; }
        public bool Cozinha { get; set; }
        public bool Tanque { get; set; }//é tanque de combustivel 
    }
}
