namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updUsrPos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Codtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Usr", "ContaTesoura", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Supervisor", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Supervisor");
            DropColumn("dbo.Usr", "ContaTesoura");
            DropColumn("dbo.Usr", "Codtz");
        }
    }
}
