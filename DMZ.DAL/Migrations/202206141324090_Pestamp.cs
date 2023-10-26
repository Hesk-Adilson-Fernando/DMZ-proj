namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Percl", "Pestamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Percl", "Pestamp");
        }
    }
}
