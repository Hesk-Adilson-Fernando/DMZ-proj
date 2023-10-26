namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updaddpe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pefunc",
                c => new
                    {
                        Pefuncstamp = c.String(nullable: false, maxLength: 30),
                        Funcao = c.String(nullable: false, maxLength: 80),
                        Tipo = c.String(nullable: false, maxLength: 80),
                        Local = c.String(nullable: false, maxLength: 80),
                        DataIn = c.DateTime(nullable: false),
                        Datafim = c.DateTime(nullable: false),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pefuncstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            AddColumn("dbo.Pe", "Locali", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Ntabelado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Pontonome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Formapag", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codformp", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Dataadm", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "ReDataadm", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "Basedia", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pecont", "Padrao", c => c.Boolean(nullable: false));
            DropColumn("dbo.Peacidente", "No");
            DropColumn("dbo.Peacidente", "Nome");
            DropColumn("dbo.Peaus", "No");
            DropColumn("dbo.Peaus", "Nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Peaus", "Nome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Peaus", "No", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Peacidente", "Nome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Peacidente", "No", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Pefunc", "Pestamp", "dbo.Pe");
            DropIndex("dbo.Pefunc", new[] { "Pestamp" });
            DropColumn("dbo.Pecont", "Padrao");
            DropColumn("dbo.Pe", "Basedia");
            DropColumn("dbo.Pe", "ReDataadm");
            DropColumn("dbo.Pe", "Dataadm");
            DropColumn("dbo.Pe", "Codformp");
            DropColumn("dbo.Pe", "Formapag");
            DropColumn("dbo.Pe", "Pontonome");
            DropColumn("dbo.Pe", "Ntabelado");
            DropColumn("dbo.Pe", "Ccustamp");
            DropColumn("dbo.Pe", "Locali");
            DropTable("dbo.Pefunc");
        }
    }
}
