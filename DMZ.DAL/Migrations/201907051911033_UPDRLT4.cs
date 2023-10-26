namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDRLT4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "clnBold", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.Rlt", "clnAlign", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rlt", "clnAlign", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rlt", "clnBold", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
