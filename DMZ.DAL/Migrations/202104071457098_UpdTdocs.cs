namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTdocs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdi", "Stockmax", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Stockmin", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Stockmax", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdocf", "Stockmax");
            DropColumn("dbo.Tdoc", "Stockmin");
            DropColumn("dbo.Tdi", "Stockmax");
        }
    }
}
