namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updstfnc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StFnc", "Reffnc", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StFnc", "Reffnc");
        }
    }
}
