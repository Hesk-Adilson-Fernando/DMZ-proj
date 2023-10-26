namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdIntegra : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "ContaPgc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "ContaPgc2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "ContaPgc3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "ContaPgc4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "Integra", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Nodiario", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdi", "Diario", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "NdocCont", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdi", "DescDocCont", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Tdocf", "TesouraPgc");
            DropColumn("dbo.Tpgf", "TesouraPgc");
            DropColumn("dbo.TRcl", "TesouraPgc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TRcl", "TesouraPgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tpgf", "TesouraPgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdocf", "TesouraPgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Tdi", "DescDocCont");
            DropColumn("dbo.Tdi", "NdocCont");
            DropColumn("dbo.Tdi", "Diario");
            DropColumn("dbo.Tdi", "Nodiario");
            DropColumn("dbo.Tdi", "Integra");
            DropColumn("dbo.Contas", "ContaPgc4");
            DropColumn("dbo.Contas", "ContaPgc3");
            DropColumn("dbo.Contas", "ContaPgc2");
            DropColumn("dbo.Contas", "ContaPgc");
        }
    }
}
