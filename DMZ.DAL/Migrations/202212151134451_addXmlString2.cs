namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addXmlString2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "XmlString", c => c.String(nullable: false));
            AddColumn("dbo.TPercl", "XmlString", c => c.String(nullable: false));
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.TPercl", "ReportXml");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TPercl", "ReportXml", c => c.String(nullable: false));
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false, maxLength: 2500));
            DropColumn("dbo.TPercl", "XmlString");
            DropColumn("dbo.Rlt", "XmlString");
        }
    }
}
