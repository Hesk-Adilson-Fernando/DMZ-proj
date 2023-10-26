namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upccuemp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CCu", "Empresastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CCu", "Nome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CCu", "Codigo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CCu", "Controlanumcl", c => c.Boolean(nullable: false));
            AddColumn("dbo.CCu", "Controlanumfnc", c => c.Boolean(nullable: false));
            AddColumn("dbo.CCu", "Minimocl", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.CCu", "Maximocl", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.CCu", "Minimofnc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.CCu", "Maximofnc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CCu", "Maximofnc");
            DropColumn("dbo.CCu", "Minimofnc");
            DropColumn("dbo.CCu", "Maximocl");
            DropColumn("dbo.CCu", "Minimocl");
            DropColumn("dbo.CCu", "Controlanumfnc");
            DropColumn("dbo.CCu", "Controlanumcl");
            DropColumn("dbo.CCu", "Codigo");
            DropColumn("dbo.CCu", "Nome");
            DropColumn("dbo.CCu", "Empresastamp");
        }
    }
}
