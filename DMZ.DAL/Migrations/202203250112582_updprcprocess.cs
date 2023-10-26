namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updprcprocess : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pecc", "Cambiousd", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.Pecc", "Pestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Pestamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Prc", "Pestamp");
            DropColumn("dbo.Pecc", "Pestamp");
            DropColumn("dbo.Pecc", "Cambiousd");
        }
    }
}
