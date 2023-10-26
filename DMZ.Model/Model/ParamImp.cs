using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class ParamImp
    {
        [Key]
        public string ParamImpstamp { get; set; }
        public string Paramstamp { get; set; }
        public string Pos { get; set; }
        public string Normal1 { get; set; }
        public string Normal2 { get; set; }
        public string Ccusto { get; set; }
        public string Codccu { get; set; }
        public bool Padrao { get; set; }
        public virtual Param Param { get; set; }
    }
}
