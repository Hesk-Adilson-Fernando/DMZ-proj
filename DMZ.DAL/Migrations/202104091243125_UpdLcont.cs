namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdLcont : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lcont", "Apuraiva", c => c.Boolean(nullable: false));
            AddColumn("dbo.Lcont", "Apurares", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lcont", "Apurares");
            DropColumn("dbo.Lcont", "Apuraiva");
        }
    }
}
