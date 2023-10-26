namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Desconto")]
    public partial class Desconto
    {
        [Key]
        [StringLength(30)]
        public string Descontostamp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codigo { get; set; }

        [Required]
        [StringLength(80)]
        public string descricao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        public bool descfixo { get; set; }

        [Required]
        [StringLength(10)]
        public string qmc { get; set; }

        public DateTime qmcdathora { get; set; }

        [Required]
        [StringLength(10)]
        public string qma { get; set; }

        public DateTime qmadathora { get; set; }

        public bool decimo13 { get; set; }

        public bool retro { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tipodesc { get; set; }

        public bool vta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal insid { get; set; }

        public bool rectro { get; set; }
    }
}
