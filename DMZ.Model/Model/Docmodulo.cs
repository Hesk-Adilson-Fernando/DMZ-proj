using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public  class Docmodulo
    {
        [Key]
        public string Docmodulostamp { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? Estado { get; set; } = false;
        public string Rltstamp { get; set; } = null;
        public string Tdistamp { get; set; } = null;
        public string Tdocstamp { get; set; }= null;
        public string Tdocfstamp { get; set; }= null;
        public virtual Tdi Tdi { get; set; }
        public virtual Tdocf Tdocf { get; set; }
        public virtual Tdoc Tdoc { get; set; }
        public virtual Rlt Rlt { get; set; }
    }
}
