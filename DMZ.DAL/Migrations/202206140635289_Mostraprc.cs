namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mostraprc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "Mostraprc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "Mostraprc");
        }
    }
}
