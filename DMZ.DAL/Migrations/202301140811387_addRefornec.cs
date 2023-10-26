namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRefornec : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Refornec", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Refornec", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Refornec", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faccl", "Refornec");
            DropColumn("dbo.Dil", "Refornec");
            DropColumn("dbo.Factl", "Refornec");
        }
    }
}
