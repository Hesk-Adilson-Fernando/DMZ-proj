namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdFactPj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClContas",
                c => new
                    {
                        ClContasstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Banco = c.String(nullable: false, maxLength: 80),
                        Nib = c.String(nullable: false, maxLength: 80),
                        Swift = c.String(nullable: false, maxLength: 80),
                        Iban = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.ClContasstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            AddColumn("dbo.Fact", "Localpartida", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Datapartida", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Requisicao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Localentrega", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Localpartida", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClContas", "Clstamp", "dbo.Cl");
            DropIndex("dbo.ClContas", new[] { "Clstamp" });
            DropColumn("dbo.Pj", "Localpartida");
            DropColumn("dbo.Pj", "Localentrega");
            DropColumn("dbo.Fact", "Requisicao");
            DropColumn("dbo.Fact", "Datapartida");
            DropColumn("dbo.Fact", "Localpartida");
            DropTable("dbo.ClContas");
        }
    }
}
