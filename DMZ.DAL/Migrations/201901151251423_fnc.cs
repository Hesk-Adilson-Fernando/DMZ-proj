namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fnc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Prontopag", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cl", "Prontopag");
        }
    }
}
