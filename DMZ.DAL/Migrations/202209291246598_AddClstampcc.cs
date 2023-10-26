namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClstampcc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cc", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cc", "Usrstamp");
        }
    }
}
