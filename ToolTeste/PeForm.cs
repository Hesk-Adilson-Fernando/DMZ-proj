namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PeForm")]
    public partial class PeForm
    {
        [Required]
        [StringLength(60)]
        public string curso { get; set; }

        [Required]
        [StringLength(60)]
        public string tipo { get; set; }

        [Required]
        [StringLength(60)]
        public string instituicao { get; set; }

        [Required]
        [StringLength(60)]
        public string nivel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codnivel { get; set; }

        public DateTime dataIn { get; set; }

        public DateTime datafim { get; set; }

        [Required]
        [StringLength(30)]
        public string duracao { get; set; }

        [Key]
        [StringLength(30)]
        public string peformstamp { get; set; }

        [Required]
        [StringLength(30)]
        public string pestamp { get; set; }

        [Required]
        [StringLength(10)]
        public string codpais { get; set; }

        [Required]
        [StringLength(60)]
        public string pais { get; set; }

        [Required]
        [StringLength(10)]
        public string anofreq { get; set; }
    }
}
