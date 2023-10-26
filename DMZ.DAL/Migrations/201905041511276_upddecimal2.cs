namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upddecimal2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cambio", "Compra", c => c.Decimal(nullable: false, precision: 14, scale: 2));
            AlterColumn("dbo.Cambio", "Venda", c => c.Decimal(nullable: false, precision: 14, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cambio", "Venda", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Cambio", "Compra", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
    }
}
