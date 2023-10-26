namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updrcll : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rcll", "Anulado", c => c.Boolean(nullable: false));
            DropColumn("dbo.Rcll", "status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rcll", "status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Rcll", "Anulado");
        }
    }
}
