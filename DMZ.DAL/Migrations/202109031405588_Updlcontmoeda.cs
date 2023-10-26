namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updlcontmoeda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "Moedaest", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "Cambio", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Ml", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Lcont", "Cambio", c => c.Decimal(nullable: false, precision: 8, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lcont", "Cambio", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Ml", "Moeda");
            DropColumn("dbo.Ml", "Moeda2");
            DropColumn("dbo.Ml", "Cambio");
            DropColumn("dbo.Contas", "Moedaest");
        }
    }
}
