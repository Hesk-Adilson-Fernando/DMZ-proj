namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updtpgfrh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tpgf", "Rh", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tpgf", "Rh");
        }
    }
}
