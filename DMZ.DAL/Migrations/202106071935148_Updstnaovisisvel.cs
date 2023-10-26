namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updstnaovisisvel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Naovisisvel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Naovisisvel");
        }
    }
}
