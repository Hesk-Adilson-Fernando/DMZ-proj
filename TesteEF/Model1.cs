using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TesteEF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<cpoc> cpocs { get; set; }
        public virtual DbSet<cpocCompra> cpocCompras { get; set; }
        public virtual DbSet<cpocVend> cpocVends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cpoc>()
                .Property(e => e.cpocstamp)
                .IsUnicode(false);

            modelBuilder.Entity<cpoc>()
                .Property(e => e.codcpoc)
                .HasPrecision(8, 0);

            modelBuilder.Entity<cpoc>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cpoc>()
                .Property(e => e.qmc)
                .IsUnicode(false);

            modelBuilder.Entity<cpoc>()
                .Property(e => e.qma)
                .IsUnicode(false);

            modelBuilder.Entity<cpoc>()
                .HasMany(e => e.cpocCompras)
                .WithOptional(e => e.cpoc)
                .WillCascadeOnDelete();

            modelBuilder.Entity<cpoc>()
                .HasMany(e => e.cpocVends)
                .WithOptional(e => e.cpoc)
                .WillCascadeOnDelete();

            modelBuilder.Entity<cpocCompra>()
                .Property(e => e.cpocComprastamp)
                .IsUnicode(false);

            modelBuilder.Entity<cpocCompra>()
                .Property(e => e.cpocstamp)
                .IsUnicode(false);

            modelBuilder.Entity<cpocCompra>()
                .Property(e => e.valCompra)
                .IsUnicode(false);

            modelBuilder.Entity<cpocCompra>()
                .Property(e => e.IVA)
                .IsUnicode(false);

            modelBuilder.Entity<cpocCompra>()
                .Property(e => e.desconto)
                .IsUnicode(false);

            modelBuilder.Entity<cpocVend>()
                .Property(e => e.cpocvendstamp)
                .IsUnicode(false);

            modelBuilder.Entity<cpocVend>()
                .Property(e => e.cpocstamp)
                .IsUnicode(false);

            modelBuilder.Entity<cpocVend>()
                .Property(e => e.valVenda)
                .IsUnicode(false);

            modelBuilder.Entity<cpocVend>()
                .Property(e => e.IVA)
                .IsUnicode(false);

            modelBuilder.Entity<cpocVend>()
                .Property(e => e.desconto)
                .IsUnicode(false);
        }
    }
}
