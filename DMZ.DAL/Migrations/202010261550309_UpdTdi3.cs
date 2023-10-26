namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTdi3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tdi", "Folhaobra");
            DropColumn("dbo.Tdi", "Rcombustivel");
            DropColumn("dbo.Tdi", "Folhatrabalho");
            DropColumn("dbo.Tdi", "Guiacarga");
            DropColumn("dbo.Tdi", "Sinistros");
            DropColumn("dbo.Tdi", "Multas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tdi", "Multas", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Sinistros", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Guiacarga", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Folhatrabalho", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Rcombustivel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Folhaobra", c => c.Boolean(nullable: false));
        }
    }
}
