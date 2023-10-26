namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tipousr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Tipousr", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Tipousr");
        }
    }
}
