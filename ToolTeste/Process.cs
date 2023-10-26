namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Process")]
    public partial class Process
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Process()
        {
            PRCEXTRAs = new HashSet<PRCEXTRA>();
        }

        public DateTime Data { get; set; }

        [Required]
        [StringLength(15)]
        public string Mes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Ano { get; set; }

        [Required]
        [StringLength(60)]
        public string descricao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codigo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Processado { get; set; }

        public DateTime ultproc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Nrmes { get; set; }

        [Required]
        [StringLength(100)]
        public string obs { get; set; }

        [Key]
        [StringLength(30)]
        public string processstamp { get; set; }

        [Required]
        [StringLength(10)]
        public string qmc { get; set; }

        public DateTime qmcdathora { get; set; }

        [Required]
        [StringLength(10)]
        public string qma { get; set; }

        public DateTime qmadathora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRCEXTRA> PRCEXTRAs { get; set; }
    }
}
