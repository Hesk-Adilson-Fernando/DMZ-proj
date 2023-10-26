namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmesas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mesas", "Obs", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Mesas", "Mesano");
            DropColumn("dbo.Mesas", "Inactivo");
            DropColumn("dbo.Mesas", "Codloc");
            DropColumn("dbo.Mesas", "DescLocal");
            DropColumn("dbo.Mesas", "LocMesasstamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mesas", "LocMesasstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mesas", "DescLocal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mesas", "Codloc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Mesas", "Inactivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mesas", "Mesano", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Mesas", "Obs");
        }
    }
}
