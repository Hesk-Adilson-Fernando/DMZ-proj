namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContasstampUsr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Rdfl", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Rdl", "Rd_Rdstamp", "dbo.Rd");
            DropIndex("dbo.Cc", new[] { "Rdstamp" });
            DropIndex("dbo.Formasp", new[] { "Rdstamp" });
            DropIndex("dbo.Formasp", new[] { "Rdfstamp" });
            DropIndex("dbo.Fcc", new[] { "Rdfstamp" });
            DropIndex("dbo.Rdfl", new[] { "Rdfstamp" });
            DropIndex("dbo.Rdl", new[] { "Rd_Rdstamp" });
            AddColumn("dbo.Formasp", "Oristamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Formasp", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Pgf", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mvt", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Percl", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Formasp", "Rdstamp");
            DropColumn("dbo.Formasp", "Rdfstamp");
            DropColumn("dbo.Usr", "Oristamp");
            DropTable("dbo.Rdf");
            DropTable("dbo.Rdfl");
            DropTable("dbo.Rd");
            DropTable("dbo.Rdl");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rdl",
                c => new
                    {
                        Rdstamp = c.String(nullable: false, maxLength: 80),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        valorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mvalorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Rdlstamp = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                        Rd_Rdstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Rdstamp);
            
            CreateTable(
                "dbo.Rd",
                c => new
                    {
                        Rdstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Banco = c.String(nullable: false, maxLength: 80),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 80),
                        bancoprov = c.String(nullable: false, maxLength: 80),
                        anulado = c.Boolean(nullable: false),
                        ccusto = c.String(nullable: false, maxLength: 80),
                        numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        sigla = c.String(nullable: false, maxLength: 80),
                        Nomedoc = c.String(nullable: false, maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovcc = c.String(nullable: false, maxLength: 80),
                        Nomecomerc = c.String(nullable: false, maxLength: 80),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(nullable: false, maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(nullable: false, maxLength: 80),
                        Estabno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estabnome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Rdstamp);
            
            CreateTable(
                "dbo.Rdfl",
                c => new
                    {
                        Rdflstamp = c.String(nullable: false, maxLength: 80),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mvalorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Rdfstamp = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Rdflstamp);
            
            CreateTable(
                "dbo.Rdf",
                c => new
                    {
                        Rdfstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        data = c.DateTime(nullable: false),
                        no = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome = c.String(nullable: false, maxLength: 80),
                        moeda = c.String(nullable: false, maxLength: 80),
                        Banco = c.String(nullable: false, maxLength: 80),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Bancoprov = c.String(nullable: false, maxLength: 80),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Numtitulo = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Nomedoc = c.String(nullable: false, maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovcc = c.String(nullable: false, maxLength: 80),
                        Anulado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Rdfstamp);
            
            AddColumn("dbo.Usr", "Oristamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Formasp", "Rdfstamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Formasp", "Rdstamp", c => c.String(maxLength: 80));
            DropColumn("dbo.Usr", "Contasstamp");
            DropColumn("dbo.RCL", "Ccustamp");
            DropColumn("dbo.Percl", "Ccustamp");
            DropColumn("dbo.Mvt", "Ccustamp");
            DropColumn("dbo.Pgf", "Ccustamp");
            DropColumn("dbo.Formasp", "Cambiousd");
            DropColumn("dbo.Formasp", "Oristamp");
            CreateIndex("dbo.Rdl", "Rd_Rdstamp");
            CreateIndex("dbo.Rdfl", "Rdfstamp");
            CreateIndex("dbo.Fcc", "Rdfstamp");
            CreateIndex("dbo.Formasp", "Rdfstamp");
            CreateIndex("dbo.Formasp", "Rdstamp");
            CreateIndex("dbo.Cc", "Rdstamp");
            AddForeignKey("dbo.Rdl", "Rd_Rdstamp", "dbo.Rd", "Rdstamp");
            AddForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd", "Rdstamp");
            AddForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd", "Rdstamp");
            AddForeignKey("dbo.Rdfl", "Rdfstamp", "dbo.Rdf", "Rdfstamp", cascadeDelete: true);
            AddForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf", "Rdfstamp");
            AddForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf", "Rdfstamp");
        }
    }
}
