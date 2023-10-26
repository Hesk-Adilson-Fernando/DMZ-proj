namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updstquant : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dil", "Quant", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dil", "Quant", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
