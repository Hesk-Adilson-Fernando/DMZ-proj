namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updrltcc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RltCc", "Codccu", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RltCc", "Codccu", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
