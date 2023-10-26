namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addXmlString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdi", "XmlString", c => c.String(nullable: false));
            AddColumn("dbo.Tdoc", "XmlString", c => c.String(nullable: false));
            AddColumn("dbo.Tdocf", "XmlString", c => c.String(nullable: false));
            AddColumn("dbo.Tpgf", "XmlString", c => c.String(nullable: false));
            AddColumn("dbo.TRcl", "XmlString", c => c.String(nullable: false));
            AlterColumn("dbo.Tdi", "ReportXml", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Tdoc", "ReportXml", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tdoc", "ReportXml", c => c.String(nullable: false));
            AlterColumn("dbo.Tdi", "ReportXml", c => c.String(nullable: false));
            DropColumn("dbo.TRcl", "XmlString");
            DropColumn("dbo.Tpgf", "XmlString");
            DropColumn("dbo.Tdocf", "XmlString");
            DropColumn("dbo.Tdoc", "XmlString");
            DropColumn("dbo.Tdi", "XmlString");
        }
    }
}
