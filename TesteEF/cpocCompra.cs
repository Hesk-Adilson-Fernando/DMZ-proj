namespace TesteEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cpocCompra")]
    public partial class cpocCompra
    {
        [Key]
        [StringLength(30)]
        public string cpocComprastamp { get; set; }

        [StringLength(30)]
        public string cpocstamp { get; set; }

        public int tabiva { get; set; }

        [Required]
        [StringLength(12)]
        public string valCompra { get; set; }

        [Required]
        [StringLength(12)]
        public string IVA { get; set; }

        [Required]
        [StringLength(12)]
        public string desconto { get; set; }

        public bool nac { get; set; }

        public virtual cpoc cpoc { get; set; }
    }
}
