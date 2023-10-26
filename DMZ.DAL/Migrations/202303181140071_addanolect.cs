namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addanolect : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Anolect");
            AddColumn("dbo.Anolect", "Anolectstamp", c => c.String(nullable: false, maxLength: 80));
            AddPrimaryKey("dbo.Anolect", "Anolectstamp");
            DropColumn("dbo.Anolect", "AnoLectivostamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Anolect", "AnoLectivostamp", c => c.String(nullable: false, maxLength: 80));
            DropPrimaryKey("dbo.Anolect");
            DropColumn("dbo.Anolect", "Anolectstamp");
            AddPrimaryKey("dbo.Anolect", "AnoLectivostamp");
        }
    }
}
