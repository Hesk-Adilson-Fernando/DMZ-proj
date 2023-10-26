namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _111111 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false));
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false));
            CreateIndex("dbo.Usracessos", "Usrstamp");
            AddForeignKey("dbo.Usracessos", "Usrstamp", "dbo.Usr", "Usrstamp", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usracessos", "Usrstamp", "dbo.Usr");
            DropIndex("dbo.Usracessos", new[] { "Usrstamp" });
            AlterColumn("dbo.Rlt", "ReportXml", c => c.String(nullable: false, maxLength: 2500));
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false, maxLength: 2500));
        }
    }
}
