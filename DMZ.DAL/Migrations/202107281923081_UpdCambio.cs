namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdCambio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Di", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AlterColumn("dbo.Fact", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AlterColumn("dbo.RCL", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RCL", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Fact", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            DropColumn("dbo.Di", "Cambiousd");
        }
    }
}
