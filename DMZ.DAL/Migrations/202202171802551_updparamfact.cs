namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparamfact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Motivoanula", c => c.String(nullable: false, maxLength: 2000));
            AddColumn("dbo.Fact", "Nrdocanuala", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "ObrigaNc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "ObrigaNc");
            DropColumn("dbo.Fact", "Nrdocanuala");
            DropColumn("dbo.Fact", "Motivoanula");
        }
    }
}
