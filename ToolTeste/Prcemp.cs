namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prcemp")]
    public partial class Prcemp
    {
        [Column(TypeName = "numeric")]
        public decimal nrmes { get; set; }

        [Required]
        [StringLength(60)]
        public string mes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ano { get; set; }

        [Key]
        [StringLength(30)]
        public string Prcempstamp { get; set; }

        [Required]
        [StringLength(30)]
        public string peemplstamp { get; set; }

        [Required]
        [StringLength(30)]
        public string Prcstamp { get; set; }

        public virtual peempl peempl { get; set; }
    }
}
