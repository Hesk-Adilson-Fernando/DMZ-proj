namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Upddinuitmorada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Di", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Nuit", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Di", "Nuit");
            DropColumn("dbo.Di", "Morada");
        }
    }
}
