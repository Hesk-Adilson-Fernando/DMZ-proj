namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdDiObs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dil", "Obs", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Di", "Obs", c => c.String(nullable: false, maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Di", "Obs", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Dil", "Obs");
        }
    }
}
