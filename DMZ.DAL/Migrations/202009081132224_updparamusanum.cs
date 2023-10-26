namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparamusanum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Usanumauto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Nummascara", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Nummascara");
            DropColumn("dbo.Param", "Usanumauto");
        }
    }
}
