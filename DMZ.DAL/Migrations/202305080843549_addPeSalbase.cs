namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPeSalbase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PeSalbase",
                c => new
                    {
                        PeSalbasestamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Datalanc = c.DateTime(nullable: false),
                        Nrhoras = c.Decimal(nullable: false, precision: 16, scale: 2),
                        SalHora = c.Decimal(nullable: false, precision: 16, scale: 2),
                        ValBasico = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.PeSalbasestamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            AddColumn("dbo.Prc", "PeSalbasestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Usacademia", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeSalbase", "Pestamp", "dbo.Pe");
            DropIndex("dbo.PeSalbase", new[] { "Pestamp" });
            DropColumn("dbo.Param", "Usacademia");
            DropColumn("dbo.Prc", "PeSalbasestamp");
            DropTable("dbo.PeSalbase");
        }
    }
}
