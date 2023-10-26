namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updusr1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Codposto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Usr", "Posto", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Posto");
            DropColumn("dbo.Usr", "Codposto");
        }
    }
}
