namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Planomultal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Planomultal",
                c => new
                    {
                        Planomultalstamp = c.String(nullable: false, maxLength: 80),
                        Planomultastamp = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Perc = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Multadesc = c.String(nullable: false, maxLength: 80),
                        Usaperc = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Planomultalstamp)
                .ForeignKey("dbo.Planomulta", t => t.Planomultastamp, cascadeDelete: true)
                .Index(t => t.Planomultastamp);
            
            AddColumn("dbo.Planomulta", "Anosem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Planomulta", "Anosemstamp", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Planomulta", "Valor");
            DropColumn("dbo.Planomulta", "Perc");
            DropColumn("dbo.Planomulta", "Condicional");
            DropColumn("dbo.Planomulta", "Tipodesc");
            DropColumn("dbo.Planomulta", "Accao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Planomulta", "Accao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Planomulta", "Tipodesc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Planomulta", "Condicional", c => c.Boolean(nullable: false));
            AddColumn("dbo.Planomulta", "Perc", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AddColumn("dbo.Planomulta", "Valor", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            DropForeignKey("dbo.Planomultal", "Planomultastamp", "dbo.Planomulta");
            DropIndex("dbo.Planomultal", new[] { "Planomultastamp" });
            DropColumn("dbo.Planomulta", "Anosemstamp");
            DropColumn("dbo.Planomulta", "Anosem");
            DropTable("dbo.Planomultal");
        }
    }
}
