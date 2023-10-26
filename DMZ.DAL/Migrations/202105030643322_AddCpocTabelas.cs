namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCpocTabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cpoc",
                c => new
                    {
                        Cpocstamp = c.String(nullable: false, maxLength: 80),
                        Codcpoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Qmc = c.String(nullable: false, maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(nullable: false, maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                        Servico = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Cpocstamp);
            
            CreateTable(
                "dbo.CpocCompra",
                c => new
                    {
                        CpocComprastamp = c.String(nullable: false, maxLength: 30),
                        Cpocstamp = c.String(nullable: false, maxLength: 80),
                        Tabiva = c.Int(nullable: false),
                        ValCompra = c.String(nullable: false, maxLength: 12),
                        IVA = c.String(nullable: false, maxLength: 12),
                        Desconto = c.String(nullable: false, maxLength: 12),
                        Nac = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CpocComprastamp)
                .ForeignKey("dbo.Cpoc", t => t.Cpocstamp, cascadeDelete: true)
                .Index(t => t.Cpocstamp);
            
            CreateTable(
                "dbo.CpocVend",
                c => new
                    {
                        Cpocvendstamp = c.String(nullable: false, maxLength: 30),
                        Cpocstamp = c.String(nullable: false, maxLength: 80),
                        Tabiva = c.Int(nullable: false),
                        ValVenda = c.String(nullable: false, maxLength: 12),
                        Iva = c.String(nullable: false, maxLength: 12),
                        Desconto = c.String(nullable: false, maxLength: 12),
                        Nac = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Cpocvendstamp)
                .ForeignKey("dbo.Cpoc", t => t.Cpocstamp, cascadeDelete: true)
                .Index(t => t.Cpocstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CpocVend", "Cpocstamp", "dbo.Cpoc");
            DropForeignKey("dbo.CpocCompra", "Cpocstamp", "dbo.Cpoc");
            DropIndex("dbo.CpocVend", new[] { "Cpocstamp" });
            DropIndex("dbo.CpocCompra", new[] { "Cpocstamp" });
            DropTable("dbo.CpocVend");
            DropTable("dbo.CpocCompra");
            DropTable("dbo.Cpoc");
        }
    }
}
