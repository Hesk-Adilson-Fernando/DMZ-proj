namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pe", "Mecanico", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pe", "Mecanico");
        }
    }
}
