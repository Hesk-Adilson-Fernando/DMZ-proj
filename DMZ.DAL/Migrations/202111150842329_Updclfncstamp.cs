namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updclfncstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cc", "Clstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Clstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Formasp", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Fncstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fcc", "Fncstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mvt", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mvt", "Contasstamp");
            DropColumn("dbo.Fcc", "Fncstamp");
            DropColumn("dbo.Facc", "Fncstamp");
            DropColumn("dbo.Formasp", "Contasstamp");
            DropColumn("dbo.Fact", "Clstamp");
            DropColumn("dbo.Cc", "Clstamp");
        }
    }
}
