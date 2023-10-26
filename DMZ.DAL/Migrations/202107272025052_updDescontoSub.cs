namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updDescontoSub : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Desconto", "Codigo", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pedesc", "Codigo", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pesub", "Codigo", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Sub", "Codigo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sub", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pesub", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pedesc", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Desconto", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
