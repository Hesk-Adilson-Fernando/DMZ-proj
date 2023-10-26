namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updobs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdi", "Obs", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Fact", "Obs", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Tdoc", "Obs2", c => c.String(nullable: false, maxLength: 1200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tdoc", "Obs2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fact", "Obs", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Tdi", "Obs");
        }
    }
}
