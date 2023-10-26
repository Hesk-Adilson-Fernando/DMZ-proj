namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdClnoType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cc", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Di", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fcc", "No", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fcc", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Cc", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
