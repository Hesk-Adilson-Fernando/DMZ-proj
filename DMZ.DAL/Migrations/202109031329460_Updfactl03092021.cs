namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updfactl03092021 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Factl", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Factl", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Dil", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Faccl", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Pjesc", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjesc", "Moeda2", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pjesc", "Moeda2");
            DropColumn("dbo.Pjesc", "Moeda");
            DropColumn("dbo.Pjesc", "Cambiousd");
            DropColumn("dbo.Faccl", "Moeda2");
            DropColumn("dbo.Faccl", "Moeda");
            DropColumn("dbo.Faccl", "Cambiousd");
            DropColumn("dbo.Dil", "Moeda2");
            DropColumn("dbo.Dil", "Moeda");
            DropColumn("dbo.Dil", "Cambiousd");
            DropColumn("dbo.Factl", "Moeda2");
            DropColumn("dbo.Factl", "Moeda");
            DropColumn("dbo.Factl", "Cambiousd");
        }
    }
}
