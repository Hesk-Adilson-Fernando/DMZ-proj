namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrclUsrstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pgf", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Percl", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RCL", "Usrstamp");
            DropColumn("dbo.Percl", "Usrstamp");
            DropColumn("dbo.Pgf", "Usrstamp");
        }
    }
}
