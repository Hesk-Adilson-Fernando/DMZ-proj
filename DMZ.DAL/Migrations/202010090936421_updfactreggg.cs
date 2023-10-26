namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfactreggg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factreg",
                c => new
                    {
                        Factregstamp = c.String(nullable: false, maxLength: 80),
                        Factstamp = c.String(nullable: false, maxLength: 80),
                        Ccstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valpreg = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Valorreg = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.Factregstamp)
                .ForeignKey("dbo.Fact", t => t.Factstamp, cascadeDelete: true)
                .Index(t => t.Factstamp);
            
            AddColumn("dbo.Fact", "Pjnome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Regularizado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "ValRegularizado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Liquidofactura", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Dataentrega", c => c.DateTime(nullable: false));
            DropColumn("dbo.Fact", "Codagree");
            DropColumn("dbo.Fact", "Dadjudicado");
            DropColumn("dbo.Fact", "Nadjudicado");
            DropColumn("dbo.Fact", "Tprocess");
            DropColumn("dbo.Fact", "Nrfornec");
            DropColumn("dbo.Fact", "Ndeclara");
            DropColumn("dbo.Fact", "Refcl");
            DropColumn("dbo.Fact", "Tpdescmercad");
            DropColumn("dbo.Fact", "Ocusto");
            DropColumn("dbo.Fact", "Acerto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fact", "Acerto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Ocusto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Tpdescmercad", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Refcl", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Ndeclara", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Nrfornec", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Tprocess", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Nadjudicado", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Dadjudicado", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fact", "Codagree", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Factreg", "Factstamp", "dbo.Fact");
            DropIndex("dbo.Factreg", new[] { "Factstamp" });
            AlterColumn("dbo.Fact", "Dataentrega", c => c.Boolean(nullable: false));
            DropColumn("dbo.Fact", "Liquidofactura");
            DropColumn("dbo.Fact", "ValRegularizado");
            DropColumn("dbo.Fact", "Regularizado");
            DropColumn("dbo.Fact", "Pjnome");
            DropTable("dbo.Factreg");
        }
    }
}
