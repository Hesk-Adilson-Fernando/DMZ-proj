namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRCEXTRA")]
    public partial class PRCEXTRA
    {
        [Key]
        [StringLength(30)]
        public string PRCEXTRASTAMP { get; set; }

        [Required]
        [StringLength(30)]
        public string PROCESSSTAMP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NRMES { get; set; }

        [Required]
        [StringLength(15)]
        public string MES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ANO { get; set; }

        public DateTime DATA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NO { get; set; }

        [Required]
        [StringLength(60)]
        public string NOME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CODCAT { get; set; }

        [Required]
        [StringLength(40)]
        public string CAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CODDESC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CODFUN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CODESC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ESCALAO { get; set; }

        [Required]
        [StringLength(40)]
        public string INDICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CODSEC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CODCL { get; set; }

        [Required]
        [StringLength(1)]
        public string CLASSE { get; set; }

        public bool QUOTA { get; set; }

        [Required]
        [StringLength(60)]
        public string SIND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NSIND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CODSIT { get; set; }

        [Required]
        [StringLength(40)]
        public string SITUACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BASECATEG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTSUB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTABONUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTDESC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LIQUIDO { get; set; }

        public bool FECHADO { get; set; }

        [Required]
        [StringLength(10)]
        public string QMC { get; set; }

        public DateTime QMCDATHORA { get; set; }

        [Required]
        [StringLength(10)]
        public string QMA { get; set; }

        public DateTime QMADATHORA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EXTRA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTAL { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string OBS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DIFERENCA { get; set; }

        public virtual Process Process { get; set; }
    }
}
