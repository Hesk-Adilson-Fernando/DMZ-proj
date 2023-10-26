namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updst2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Trailref", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Traildesc", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Traildesc");
            DropColumn("dbo.St", "Trailref");
        }
    }
}
