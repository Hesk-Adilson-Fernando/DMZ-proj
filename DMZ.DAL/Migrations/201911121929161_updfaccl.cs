namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfaccl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Descarm", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Descarm", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faccl", "Descarm");
            DropColumn("dbo.Factl", "Descarm");
        }
    }
}
