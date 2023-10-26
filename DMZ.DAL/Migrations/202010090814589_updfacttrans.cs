namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfacttrans : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Entrega", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "Dataentrega", c => c.Boolean(nullable: false));
            DropColumn("dbo.Fact", "Impresso");
            DropColumn("dbo.Fact", "Usrimpress");
            DropColumn("dbo.Fact", "Impressodh");
            DropColumn("dbo.Fact", "Volumes");
            DropColumn("dbo.Fact", "Cifmoeda");
            DropColumn("dbo.Fact", "Cifmt");
            DropColumn("dbo.Fact", "Cifusd");
            DropColumn("dbo.Fact", "Cambiousd");
            DropColumn("dbo.Fact", "Optintro");
            DropColumn("dbo.Fact", "Calcfrete");
            DropColumn("dbo.Fact", "Calcseguro");
            DropColumn("dbo.Fact", "Fob");
            DropColumn("dbo.Fact", "Frete");
            DropColumn("dbo.Fact", "Seguro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fact", "Seguro", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Frete", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Fob", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Calcseguro", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "Calcfrete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "Optintro", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Fact", "Cifusd", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Fact", "Cifmt", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Fact", "Cifmoeda", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Fact", "Volumes", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Impressodh", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fact", "Usrimpress", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Impresso", c => c.Boolean(nullable: false));
            DropColumn("dbo.Fact", "Dataentrega");
            DropColumn("dbo.Fact", "Entrega");
        }
    }
}
