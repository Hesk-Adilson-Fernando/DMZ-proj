namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("meses")]
    public partial class mes
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string Descricao { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal Codigo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal codtipo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string mesesstamp { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string qmc { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime qmcdathora { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string qma { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime qmadathora { get; set; }
    }
}
