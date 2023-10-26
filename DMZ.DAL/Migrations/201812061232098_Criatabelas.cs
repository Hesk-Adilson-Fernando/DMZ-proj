namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criatabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auxiliar",
                c => new
                    {
                        Auxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tabela = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desctabela = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Auxiliarstamp);
            
            CreateTable(
                "dbo.Cl",
                c => new
                    {
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(maxLength: 80),
                        Nome = c.String(maxLength: 80),
                        Morada = c.String(maxLength: 80),
                        Telefone = c.String(maxLength: 80),
                        Celular = c.String(maxLength: 80),
                        Fax = c.String(maxLength: 80),
                        Email = c.String(maxLength: 80),
                        Nuit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda = c.String(maxLength: 80),
                        Status = c.Boolean(nullable: false),
                        Datacl = c.DateTime(nullable: false),
                        Obs = c.String(maxLength: 250),
                        imagem = c.Binary(),
                    })
                .PrimaryKey(t => t.Clstamp);
            
            CreateTable(
                "dbo.Dist",
                c => new
                    {
                        Diststamp = c.String(nullable: false, maxLength: 80),
                        Codprov = c.Decimal(nullable: false, precision: 9, scale: 0),
                        CodDist = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Provstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Diststamp)
                .ForeignKey("dbo.Prov", t => t.Provstamp, cascadeDelete: true)
                .Index(t => t.Provstamp);
            
            CreateTable(
                "dbo.Pad",
                c => new
                    {
                        Padstamp = c.String(nullable: false, maxLength: 80),
                        Codpad = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Coddist = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Diststamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Padstamp)
                .ForeignKey("dbo.Dist", t => t.Diststamp)
                .Index(t => t.Diststamp);
            
            CreateTable(
                "dbo.Prov",
                c => new
                    {
                        Provstamp = c.String(nullable: false, maxLength: 80),
                        Codprov = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Provstamp);
            
            CreateTable(
                "dbo.Paises",
                c => new
                    {
                        Paisestamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Paisestamp);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Statustamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Statustamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dist", "Provstamp", "dbo.Prov");
            DropForeignKey("dbo.Pad", "Diststamp", "dbo.Dist");
            DropIndex("dbo.Pad", new[] { "Diststamp" });
            DropIndex("dbo.Dist", new[] { "Provstamp" });
            DropTable("dbo.Status");
            DropTable("dbo.Paises");
            DropTable("dbo.Prov");
            DropTable("dbo.Pad");
            DropTable("dbo.Dist");
            DropTable("dbo.Cl");
            DropTable("dbo.Auxiliar");
        }
    }
}
