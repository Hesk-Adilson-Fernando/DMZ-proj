namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRH2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf");
            DropIndex("dbo.Mvt", new[] { "Trfstamp" });
            CreateTable(
                "dbo.Percl",
                c => new
                    {
                        Perclstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Banco = c.String(nullable: false, maxLength: 80),
                        Total = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mtotal = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Process = c.Boolean(nullable: false),
                        Dprocess = c.DateTime(nullable: false),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Nomedoc = c.String(nullable: false, maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovcc = c.String(nullable: false, maxLength: 80),
                        Codmovtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovtz = c.String(nullable: false, maxLength: 80),
                        Nomecomerc = c.String(nullable: false, maxLength: 80),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(nullable: false, maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(nullable: false, maxLength: 80),
                        Estabno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estabnome = c.String(nullable: false, maxLength: 80),
                        Cambiousd = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Moeda2 = c.String(nullable: false, maxLength: 80),
                        Especial = c.Boolean(nullable: false),
                        Pjno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        PjNome = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 600),
                        TotalAbonos = c.Decimal(nullable: false, precision: 16, scale: 2),
                        TotalDescontos = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Anulado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Perclstamp);
            
            CreateTable(
                "dbo.Pecc",
                c => new
                    {
                        Peccstamp = c.String(nullable: false, maxLength: 80),
                        Origem = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(nullable: false, maxLength: 80),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Vencim = c.DateTime(nullable: false),
                        Debito = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Debitom = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Debitof = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Debitofm = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Credito = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Creditom = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Creditof = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Creditofm = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Documento = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Saldo = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Codmov = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prcstamp = c.String(maxLength: 80),
                        Perclstamp = c.String(maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Numinterno = c.String(nullable: false, maxLength: 80),
                        Estabno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estabnome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Peccstamp)
                .ForeignKey("dbo.Percl", t => t.Perclstamp)
                .ForeignKey("dbo.Prc", t => t.Prcstamp)
                .Index(t => t.Prcstamp)
                .Index(t => t.Perclstamp);
            
            CreateTable(
                "dbo.Percll",
                c => new
                    {
                        Percllstamp = c.String(nullable: false, maxLength: 80),
                        Perclstamp = c.String(nullable: false, maxLength: 80),
                        Pccstamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Nrdoc = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valorpreg = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Valordoc = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Valorreg = c.Decimal(nullable: false, precision: 16, scale: 2),
                        ValorPend = c.Decimal(nullable: false, precision: 16, scale: 2),
                        MvalorPend = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Anulado = c.Boolean(nullable: false),
                        Numinterno = c.String(nullable: false, maxLength: 80),
                        Origem = c.String(nullable: false, maxLength: 80),
                        Mvalorpreg = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mvalorreg = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.Percllstamp)
                .ForeignKey("dbo.Percl", t => t.Perclstamp, cascadeDelete: true)
                .Index(t => t.Perclstamp);
            
            CreateTable(
                "dbo.TPercl",
                c => new
                    {
                        TPerclstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Descmovcc = c.String(nullable: false, maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codmovtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovtz = c.String(nullable: false, maxLength: 80),
                        Contastesoura = c.String(nullable: false, maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Entida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Activo = c.Boolean(nullable: false),
                        Defa = c.Boolean(nullable: false),
                        Alteranum = c.Boolean(nullable: false),
                        Usaemail = c.Boolean(nullable: false),
                        Usaanexo = c.Boolean(nullable: false),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(nullable: false, maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(nullable: false, maxLength: 80),
                        Nomfile = c.String(nullable: false, maxLength: 80),
                        Especial = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TPerclstamp);
            
            AddColumn("dbo.Formasp", "Perclstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Cl", "Plafond", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pe", "No", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Formasp", "Perclstamp");
            AddForeignKey("dbo.Formasp", "Perclstamp", "dbo.Percl", "Perclstamp");
            DropColumn("dbo.Mvt", "Dpstamp");
            DropColumn("dbo.Mvt", "Trfstamp");
            DropColumn("dbo.Mvt", "Peemplstamp");
            DropColumn("dbo.Mvt", "Prcempstamp");
            DropColumn("dbo.Proces", "CodigoMes");
            DropTable("dbo.Trf");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Trf",
                c => new
                    {
                        Trfstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Numinterno = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Origem = c.String(nullable: false, maxLength: 80),
                        Orinum = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda1 = c.String(nullable: false, maxLength: 80),
                        Destino = c.String(nullable: false, maxLength: 80),
                        Destnum = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda2 = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Numtitulo = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Trfstamp);
            
            AddColumn("dbo.Proces", "CodigoMes", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mvt", "Prcempstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mvt", "Peemplstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mvt", "Trfstamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Mvt", "Dpstamp", c => c.String(maxLength: 80));
            DropForeignKey("dbo.Percll", "Perclstamp", "dbo.Percl");
            DropForeignKey("dbo.Pecc", "Prcstamp", "dbo.Prc");
            DropForeignKey("dbo.Pecc", "Perclstamp", "dbo.Percl");
            DropForeignKey("dbo.Formasp", "Perclstamp", "dbo.Percl");
            DropIndex("dbo.Percll", new[] { "Perclstamp" });
            DropIndex("dbo.Pecc", new[] { "Perclstamp" });
            DropIndex("dbo.Pecc", new[] { "Prcstamp" });
            DropIndex("dbo.Formasp", new[] { "Perclstamp" });
            AlterColumn("dbo.Pe", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Cl", "Plafond", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Formasp", "Perclstamp");
            DropTable("dbo.TPercl");
            DropTable("dbo.Percll");
            DropTable("dbo.Pecc");
            DropTable("dbo.Percl");
            CreateIndex("dbo.Mvt", "Trfstamp");
            AddForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf", "Trfstamp");
        }
    }
}
