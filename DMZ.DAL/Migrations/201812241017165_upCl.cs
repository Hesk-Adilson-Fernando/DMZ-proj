namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upCl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cl", "No", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cl", "No", c => c.String(maxLength: 80));
        }
    }
}
