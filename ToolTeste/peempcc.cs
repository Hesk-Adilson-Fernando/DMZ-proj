namespace ToolTeste
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("peempcc")]
    public partial class peempcc
    {
        [Column(TypeName = "numeric")]
        public decimal codigo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Valor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ano { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nummes { get; set; }

        [Required]
        [StringLength(30)]
        public string mes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nrdoc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal no { get; set; }

        [Required]
        [StringLength(60)]
        public string nome { get; set; }

        public DateTime data { get; set; }

        public DateTime vencim { get; set; }

        [Column(TypeName = "numeric")]
        public decimal debito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal debitom { get; set; }

        [Column(TypeName = "numeric")]
        public decimal debitof { get; set; }

        [Column(TypeName = "numeric")]
        public decimal debitofm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal credito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal creditom { get; set; }

        [Column(TypeName = "numeric")]
        public decimal creditof { get; set; }

        [Column(TypeName = "numeric")]
        public decimal creditofm { get; set; }

        [StringLength(30)]
        public string peemplstamp { get; set; }

        [Key]
        [StringLength(30)]
        public string peempccstamp { get; set; }

        [StringLength(30)]
        public string prcstamp { get; set; }

        [StringLength(30)]
        public string origem { get; set; }

        [StringLength(30)]
        public string oristamp { get; set; }

        [StringLength(30)]
        public string documento { get; set; }

        [StringLength(30)]
        public string moeda { get; set; }

        [StringLength(30)]
        public string ccusto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codmov { get; set; }

        [StringLength(30)]
        public string empdevstamp { get; set; }

        [StringLength(30)]
        public string prcempstamp { get; set; }

        public virtual peempl peempl { get; set; }
    }
}
