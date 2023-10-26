namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDRLT2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
