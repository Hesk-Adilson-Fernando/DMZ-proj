namespace ToolTeste
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<peemp> peemps { get; set; }
        public virtual DbSet<peempcc> peempccs { get; set; }
        public virtual DbSet<peempl> peempls { get; set; }
        public virtual DbSet<PeForm> PeForms { get; set; }
        public virtual DbSet<Prcemp> Prcemps { get; set; }
        public virtual DbSet<PRCEXTRA> PRCEXTRAs { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<profiss> profisses { get; set; }
        public virtual DbSet<mes> meses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<peemp>()
                .Property(e => e.codigo)
                .HasPrecision(2, 0);

            modelBuilder.Entity<peemp>()
                .Property(e => e.Valor)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peemp>()
                .Property(e => e.no)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peemp>()
                .Property(e => e.nome)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.mesin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.numprest)
                .HasPrecision(7, 0);

            modelBuilder.Entity<peemp>()
                .Property(e => e.peempstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.pestamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.qmc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.qma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.obs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.codmes)
                .HasPrecision(2, 0);

            modelBuilder.Entity<peemp>()
                .Property(e => e.saldo)
                .HasPrecision(7, 0);

            modelBuilder.Entity<peemp>()
                .Property(e => e.ano)
                .HasPrecision(5, 0);

            modelBuilder.Entity<peemp>()
                .Property(e => e.moeda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.contatesoura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.titulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.numtitulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peemp>()
                .Property(e => e.codtz)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.codigo)
                .HasPrecision(2, 0);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.Valor)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.ano)
                .HasPrecision(5, 0);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.nummes)
                .HasPrecision(7, 0);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.mes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.nrdoc)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.no)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.nome)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.debito)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.debitom)
                .HasPrecision(16, 4);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.debitof)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.debitofm)
                .HasPrecision(16, 4);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.credito)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.creditom)
                .HasPrecision(16, 4);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.creditof)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.creditofm)
                .HasPrecision(16, 4);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.peemplstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.peempccstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.prcstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.origem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.oristamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.documento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.moeda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.ccusto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.codmov)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.empdevstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempcc>()
                .Property(e => e.prcempstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.codigo)
                .HasPrecision(2, 0);

            modelBuilder.Entity<peempl>()
                .Property(e => e.Valor)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempl>()
                .Property(e => e.mespagar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.ano)
                .HasPrecision(5, 0);

            modelBuilder.Entity<peempl>()
                .Property(e => e.nummes)
                .HasPrecision(7, 0);

            modelBuilder.Entity<peempl>()
                .Property(e => e.pago)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempl>()
                .Property(e => e.saldo)
                .HasPrecision(16, 2);

            modelBuilder.Entity<peempl>()
                .Property(e => e.peempstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.peemplstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.no)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peempl>()
                .Property(e => e.nome)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.nrdoc)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peempl>()
                .Property(e => e.moeda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.Banco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.contatesoura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.titulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.numtitulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<peempl>()
                .Property(e => e.codtz)
                .HasPrecision(10, 0);

            modelBuilder.Entity<peempl>()
                .HasMany(e => e.peempccs)
                .WithOptional(e => e.peempl)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PeForm>()
                .Property(e => e.curso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.instituicao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.nivel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.codnivel)
                .HasPrecision(3, 0);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.duracao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.peformstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.pestamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.codpais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.pais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PeForm>()
                .Property(e => e.anofreq)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prcemp>()
                .Property(e => e.nrmes)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Prcemp>()
                .Property(e => e.mes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prcemp>()
                .Property(e => e.Valor)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Prcemp>()
                .Property(e => e.ano)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Prcemp>()
                .Property(e => e.Prcempstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prcemp>()
                .Property(e => e.peemplstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prcemp>()
                .Property(e => e.Prcstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.PRCEXTRASTAMP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.PROCESSSTAMP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.NRMES)
                .HasPrecision(4, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.MES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.ANO)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.NO)
                .HasPrecision(12, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.NOME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CODCAT)
                .HasPrecision(12, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CODDESC)
                .HasPrecision(7, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CODFUN)
                .HasPrecision(7, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CODESC)
                .HasPrecision(5, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.ESCALAO)
                .HasPrecision(5, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.INDICE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CODSEC)
                .HasPrecision(7, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CODCL)
                .HasPrecision(7, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CLASSE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.SIND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.NSIND)
                .HasPrecision(16, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.CODSIT)
                .HasPrecision(7, 0);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.QMC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.QMA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRCEXTRA>()
                .Property(e => e.OBS)
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.Mes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.Ano)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Process>()
                .Property(e => e.descricao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.codigo)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Process>()
                .Property(e => e.Processado)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Process>()
                .Property(e => e.Nrmes)
                .HasPrecision(2, 0);

            modelBuilder.Entity<Process>()
                .Property(e => e.obs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.processstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.qmc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.qma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<profiss>()
                .Property(e => e.profissstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<profiss>()
                .Property(e => e.codigo)
                .HasPrecision(2, 0);

            modelBuilder.Entity<profiss>()
                .Property(e => e.descricao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<profiss>()
                .Property(e => e.qmc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<profiss>()
                .Property(e => e.qma)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mes>()
                .Property(e => e.Descricao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mes>()
                .Property(e => e.Codigo)
                .HasPrecision(2, 0);

            modelBuilder.Entity<mes>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mes>()
                .Property(e => e.codtipo)
                .HasPrecision(1, 0);

            modelBuilder.Entity<mes>()
                .Property(e => e.mesesstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mes>()
                .Property(e => e.qmc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mes>()
                .Property(e => e.qma)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
