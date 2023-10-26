namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Naoaredonda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Naoaredonda", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Naoaredonda");
        }
    }
}
