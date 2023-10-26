namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("peempl")]
    public partial class peempl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public peempl()
        {
            peempccs = new HashSet<peempcc>();
            Prcemps = new HashSet<Prcemp>();
        }

        [Column(TypeName = "numeric")]
        public decimal codigo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Required]
        [StringLength(30)]
        public string mespagar { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ano { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nummes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pago { get; set; }

        public DateTime ult_devol { get; set; }

        [Column(TypeName = "numeric")]
        public decimal saldo { get; set; }

        public bool devolvido { get; set; }

        [Required]
        [StringLength(30)]
        public string peempstamp { get; set; }

        [Key]
        [StringLength(30)]
        public string peemplstamp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal no { get; set; }

        [Required]
        [StringLength(60)]
        public string nome { get; set; }

        public DateTime data { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nrdoc { get; set; }

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

        public virtual peemp peemp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<peempcc> peempccs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prcemp> Prcemps { get; set; }
    }
}
