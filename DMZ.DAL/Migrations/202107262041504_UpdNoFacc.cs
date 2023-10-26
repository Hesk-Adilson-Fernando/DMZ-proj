namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdNoFacc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Facc", "No", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pgf", "No", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pgf", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Facc", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
