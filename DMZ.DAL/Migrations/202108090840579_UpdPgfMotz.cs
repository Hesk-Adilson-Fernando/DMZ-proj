namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPgfMotz : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pgf", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pgf", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pgf", "Descmovtz");
            DropColumn("dbo.Pgf", "Codmovtz");
        }
    }
}
