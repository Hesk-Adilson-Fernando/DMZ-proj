using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class BombaBico
    {
        [Key]
        public string BombaBicostamp { get; set; }
        public string Bombastamp { get; set; }
        public string Bicostamp { get; set; }
        public string Descricao { get; set; }//Descricao do Bico 
        public decimal IipoCombustivel { get; set; }//Codigo de combustivel 
        public virtual Bomba Bomba { get; set; }
    }
}
