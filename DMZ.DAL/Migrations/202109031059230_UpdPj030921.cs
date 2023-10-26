namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPj030921 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pj", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            AddColumn("dbo.Pj", "Msubtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "Mdesconto", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "Mtotaliva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "Mtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Fact", "Cambio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fact", "Cambio", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Pj", "Moeda2");
            DropColumn("dbo.Pj", "Moeda");
            DropColumn("dbo.Pj", "Mtotal");
            DropColumn("dbo.Pj", "Mtotaliva");
            DropColumn("dbo.Pj", "Mdesconto");
            DropColumn("dbo.Pj", "Msubtotal");
            DropColumn("dbo.Pj", "Cambiousd");
        }
    }
}
