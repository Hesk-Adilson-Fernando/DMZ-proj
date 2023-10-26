namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updstfnc1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StFnc", "Padrao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StFnc", "Padrao");
        }
    }
}
