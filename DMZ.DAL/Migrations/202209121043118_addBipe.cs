namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBipe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "ObrigaBi", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Bi", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pe", "Bi");
            DropColumn("dbo.Param", "ObrigaBi");
        }
    }
}
