namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updCrQuery : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false, maxLength: 2500));
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false, maxLength: 2500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false));
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false));
        }
    }
}
