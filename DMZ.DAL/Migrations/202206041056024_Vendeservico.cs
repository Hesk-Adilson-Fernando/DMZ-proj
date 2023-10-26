namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendeservico : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Vendeservico", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Vendeservico");
        }
    }
}
