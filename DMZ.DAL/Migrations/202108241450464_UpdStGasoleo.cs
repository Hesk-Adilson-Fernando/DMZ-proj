namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdStGasoleo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Gasoleo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dil", "Gasoleo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Faccl", "Gasoleo", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Gasoleo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Gasoleo");
            DropColumn("dbo.Faccl", "Gasoleo");
            DropColumn("dbo.Dil", "Gasoleo");
            DropColumn("dbo.Factl", "Gasoleo");
        }
    }
}
