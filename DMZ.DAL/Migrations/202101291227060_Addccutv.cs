namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addccutv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ccutv",
                c => new
                    {
                        Ccutvstamp = c.String(nullable: false, maxLength: 80),
                        Ccustamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Status = c.String(nullable: false, maxLength: 80),
                        Codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Armazem = c.String(nullable: false, maxLength: 80),
                        Tervendsusp = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ccutvstamp)
                .ForeignKey("dbo.CCu", t => t.Ccustamp, cascadeDelete: true)
                .Index(t => t.Ccustamp);
            
            CreateTable(
                "dbo.Ccutvdoc",
                c => new
                    {
                        Ccutvdocstamp = c.String(nullable: false, maxLength: 80),
                        Ccutvstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tipodoc = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Ccutvdocstamp)
                .ForeignKey("dbo.Ccutv", t => t.Ccutvstamp, cascadeDelete: true)
                .Index(t => t.Ccutvstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ccutvdoc", "Ccutvstamp", "dbo.Ccutv");
            DropForeignKey("dbo.Ccutv", "Ccustamp", "dbo.CCu");
            DropIndex("dbo.Ccutvdoc", new[] { "Ccutvstamp" });
            DropIndex("dbo.Ccutv", new[] { "Ccustamp" });
            DropTable("dbo.Ccutvdoc");
            DropTable("dbo.Ccutv");
        }
    }
}
