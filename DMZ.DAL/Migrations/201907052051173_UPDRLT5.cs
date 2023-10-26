namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDRLT5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false, maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rlt", "CrQuery", c => c.String(nullable: false, maxLength: 600));
        }
    }
}
