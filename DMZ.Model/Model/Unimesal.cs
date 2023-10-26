using DMZ.Model.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMZ.Model.Model
{
    public class Unimesal
    {
        [Key]
        [ScaffoldColumn(false)]
        public string Unimesalstamp { get; set; }
        public string Unimesastamp { get; set; }
        public string Messastamp { get; set; }
        public string Descricao { get; set; }
        [DecimalPrecision(16, 2, true)]
        public decimal Total { get; set; }
        public virtual Unimesa Unimesa { get; set; }
    }
}
