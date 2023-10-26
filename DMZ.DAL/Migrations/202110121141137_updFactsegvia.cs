namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFactsegvia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "SegundaVia", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fact", "NrFactura", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fact", "NrFactura");
            DropColumn("dbo.Fact", "SegundaVia");
        }
    }
}
