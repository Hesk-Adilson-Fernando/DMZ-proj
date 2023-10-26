namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdReportXml : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false));
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false, maxLength: 3000));
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false, maxLength: 2000));
        }
    }
}
