namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdCambioUsd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fact", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Pgf", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Pgf", "Mtotal", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Pgf", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.RCL", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RCL", "Cambiousd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgf", "Cambiousd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgf", "Mtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgf", "Total", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Cambiousd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
