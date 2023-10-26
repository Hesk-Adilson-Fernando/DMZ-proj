namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCcustoPadrao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CCu", "Padrao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CCu", "Padrao");
        }
    }
}
