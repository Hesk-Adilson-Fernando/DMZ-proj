namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Naoaltera : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Naoaltera", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Naoaltera");
        }
    }
}
