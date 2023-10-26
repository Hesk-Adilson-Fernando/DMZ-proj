namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdFactFacc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Nc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "Nd", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "Ft", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "Vd", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Nc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Nd", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Ft", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Vd", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facc", "Vd");
            DropColumn("dbo.Facc", "Ft");
            DropColumn("dbo.Facc", "Nd");
            DropColumn("dbo.Facc", "Nc");
            DropColumn("dbo.Fact", "Vd");
            DropColumn("dbo.Fact", "Ft");
            DropColumn("dbo.Fact", "Nd");
            DropColumn("dbo.Fact", "Nc");
        }
    }
}
