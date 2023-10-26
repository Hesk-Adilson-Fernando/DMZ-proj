namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upddocmod : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Docmodulo", "Codigo", c => c.Decimal(precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Docmodulo", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
