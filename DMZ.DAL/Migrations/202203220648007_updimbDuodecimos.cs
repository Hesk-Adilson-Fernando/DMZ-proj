namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updimbDuodecimos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Duodessimos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Depmensais", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Depmensais");
            DropColumn("dbo.Param", "Duodessimos");
        }
    }
}
