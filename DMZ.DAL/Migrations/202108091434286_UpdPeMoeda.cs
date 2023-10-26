namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPeMoeda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pe", "Moeda", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pe", "Moeda");
        }
    }
}
