namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updusr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Pos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "SomentePos", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "SomentePos");
            DropColumn("dbo.Usr", "Pos");
        }
    }
}
