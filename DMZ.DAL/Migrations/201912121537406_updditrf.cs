namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updditrf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Di", "TrfConta", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Di", "TrfConta");
        }
    }
}
