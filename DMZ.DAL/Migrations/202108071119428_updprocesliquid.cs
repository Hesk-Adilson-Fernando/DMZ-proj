namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updprocesliquid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proces", "Totalliquido", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proces", "Totalliquido");
        }
    }
}
