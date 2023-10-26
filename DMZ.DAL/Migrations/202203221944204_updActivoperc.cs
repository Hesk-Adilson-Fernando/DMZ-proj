namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updActivoperc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St2", "Percent", c => c.Decimal(nullable: false, precision: 5, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St2", "Percent");
        }
    }
}
