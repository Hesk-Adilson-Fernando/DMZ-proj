namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRefornefnc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pgf", "Refornec", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pgf", "Refornec");
        }
    }
}
