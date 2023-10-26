namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFACTCCPOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cc", "Pos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "Pos", c => c.Boolean(nullable: false));
            AddColumn("dbo.RCL", "Pos", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RCL", "Pos");
            DropColumn("dbo.Fact", "Pos");
            DropColumn("dbo.Cc", "Pos");
        }
    }
}
