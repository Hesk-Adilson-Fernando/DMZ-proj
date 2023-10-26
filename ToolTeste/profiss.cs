namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("profiss")]
    public partial class profiss
    {
        [Key]
        [StringLength(30)]
        public string profissstamp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codigo { get; set; }

        [Required]
        [StringLength(40)]
        public string descricao { get; set; }

        [Required]
        [StringLength(10)]
        public string qmc { get; set; }

        public DateTime qmcdathora { get; set; }

        [Required]
        [StringLength(10)]
        public string qma { get; set; }

        public DateTime qmadathora { get; set; }
    }
}
