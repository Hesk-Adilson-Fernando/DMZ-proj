namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTirps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tirps", "Padrao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tirps", "Padrao");
        }
    }
}
