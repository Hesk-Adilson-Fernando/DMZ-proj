namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterst22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St2", "Valdepact", c => c.Decimal(nullable: false, precision: 20, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St2", "Valdepact");
        }
    }
}
