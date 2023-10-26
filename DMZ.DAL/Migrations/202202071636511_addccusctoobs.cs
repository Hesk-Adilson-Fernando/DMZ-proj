namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addccusctoobs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Codccu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Obs", c => c.String(nullable: false, maxLength: 2000));
            AddColumn("dbo.Dil", "Obs", c => c.String(nullable: false, maxLength: 2000));
            AddColumn("dbo.Faccl", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Codccu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Obs", c => c.String(nullable: false, maxLength: 2500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faccl", "Obs");
            DropColumn("dbo.Faccl", "Codccu");
            DropColumn("dbo.Faccl", "Ccusto");
            DropColumn("dbo.Dil", "Obs");
            DropColumn("dbo.Factl", "Obs");
            DropColumn("dbo.Factl", "Codccu");
            DropColumn("dbo.Factl", "Ccusto");
        }
    }
}
