namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updCambiousdall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cc", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Fcc", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Pgfl", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Rcll", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rcll", "Cambiousd");
            DropColumn("dbo.Pgfl", "Cambiousd");
            DropColumn("dbo.Fcc", "Cambiousd");
            DropColumn("dbo.Cc", "Cambiousd");
        }
    }
}
