namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("peemp")]
    public partial class peemp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public peemp()
        {
            peempls = new HashSet<peempl>();
        }

        [Column(TypeName = "numeric")]
        public decimal codigo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal no { get; set; }

        [Required]
        [StringLength(60)]
        public string nome { get; set; }

        public DateTime data { get; set; }

        [Required]
        [StringLength(30)]
        public string mesin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal numprest { get; set; }

        public bool devsal { get; set; }

        public bool devolvido { get; set; }

        [Key]
        [StringLength(30)]
        public string peempstamp { get; set; }

        [Required]
        [StringLength(30)]
        public string pestamp { get; set; }

        [Required]
        [StringLength(10)]
        public string qmc { get; set; }

        public DateTime qmcdathora { get; set; }

        [Required]
        [StringLength(10)]
        public string qma { get; set; }

        public DateTime qmadathora { get; set; }

        [Required]
        [StringLength(250)]
        public string obs { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codmes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal saldo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ano { get; set; }

        [Required]
        [StringLength(3)]
        public string moeda { get; set; }

        [Required]
        [StringLength(10)]
        public string Banco { get; set; }

        [Required]
        [StringLength(40)]
        public string contatesoura { get; set; }

        [Required]
        [StringLength(20)]
        public string titulo { get; set; }

        [Required]
        [StringLength(30)]
        public string numtitulo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codtz { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<peempl> peempls { get; set; }
    }
}
