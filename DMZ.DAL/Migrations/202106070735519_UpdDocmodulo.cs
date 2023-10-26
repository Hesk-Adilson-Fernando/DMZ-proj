namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdDocmodulo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Docmodulo", "Codigo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Docmodulo", "Codigo", c => c.Decimal(precision: 9, scale: 0));
        }
    }
}
