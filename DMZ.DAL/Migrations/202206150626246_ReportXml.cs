namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReportXml : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false, maxLength: 3000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "ReportXml");
        }
    }
}
