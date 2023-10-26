namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updNuit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facc", "Nuit", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Pgf", "Nuit", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.Percl", "Nuit", c => c.Decimal(nullable: false, precision: 16, scale: 0));
            AlterColumn("dbo.RCL", "Nuit", c => c.Decimal(nullable: false, precision: 16, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RCL", "Nuit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Percl", "Nuit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgf", "Nuit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Facc", "Nuit");
        }
    }
}
