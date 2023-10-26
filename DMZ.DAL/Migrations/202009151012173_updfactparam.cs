namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfactparam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facc", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Facc", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Usamascfact", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Mascfact", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fact", "Numero", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fact", "Cambio", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Cifmoeda", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Cifmt", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Cifusd", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Facc", "Cambio", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Facc", "Cambio", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Cambiousd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Cifusd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Cifmt", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Cifmoeda", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Cambio", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Numero", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Param", "Mascfact");
            DropColumn("dbo.Param", "Usamascfact");
            DropColumn("dbo.Facc", "Moeda2");
            DropColumn("dbo.Facc", "Cambiousd");
        }
    }
}
