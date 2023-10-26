namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAbertuda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formasp", "AberturaCaixa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mvt", "AberturaCaixa", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mvt", "AberturaCaixa");
            DropColumn("dbo.Formasp", "AberturaCaixa");
        }
    }
}
