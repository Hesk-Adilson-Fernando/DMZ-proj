namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updCl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Pos", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cl", "Pos");
        }
    }
}
