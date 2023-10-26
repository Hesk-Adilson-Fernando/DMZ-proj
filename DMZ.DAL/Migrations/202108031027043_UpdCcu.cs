namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdCcu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CCu", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CCu", "Email", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CCu", "Cell", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CCu", "Nuit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CCu", "Nuit");
            DropColumn("dbo.CCu", "Cell");
            DropColumn("dbo.CCu", "Email");
            DropColumn("dbo.CCu", "Morada");
        }
    }
}
