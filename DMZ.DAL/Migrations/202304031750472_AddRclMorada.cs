namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRclMorada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pgf", "Nuit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pgf", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgf", "Localidade", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Percl", "Nuit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Percl", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Percl", "Localidade", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Nuit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.RCL", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Localidade", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RCL", "Localidade");
            DropColumn("dbo.RCL", "Morada");
            DropColumn("dbo.RCL", "Nuit");
            DropColumn("dbo.Percl", "Localidade");
            DropColumn("dbo.Percl", "Morada");
            DropColumn("dbo.Percl", "Nuit");
            DropColumn("dbo.Pgf", "Localidade");
            DropColumn("dbo.Pgf", "Morada");
            DropColumn("dbo.Pgf", "Nuit");
        }
    }
}
