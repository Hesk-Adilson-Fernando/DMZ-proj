namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updrcll1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pgfl", "MValordoc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Rcll", "MValordoc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rcll", "MValordoc");
            DropColumn("dbo.Pgfl", "MValordoc");
        }
    }
}
