namespace TesteEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cpoc")]
    public partial class cpoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cpoc()
        {
            cpocCompras = new HashSet<cpocCompra>();
            cpocVends = new HashSet<cpocVend>();
        }

        [Key]
        [StringLength(30)]
        public string cpocstamp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? codcpoc { get; set; }

        [Required]
        [StringLength(60)]
        public string descricao { get; set; }

        [Required]
        [StringLength(12)]
        public string qmc { get; set; }

        public DateTime qmcdathora { get; set; }

        [Required]
        [StringLength(12)]
        public string qma { get; set; }

        public DateTime qmadathora { get; set; }

        public bool servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cpocCompra> cpocCompras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cpocVend> cpocVends { get; set; }
    }
}
