namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class obsaddhoje : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmanota", "Obs", c => c.String(nullable: false, maxLength: 3000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turmanota", "Obs");
        }
    }
}
