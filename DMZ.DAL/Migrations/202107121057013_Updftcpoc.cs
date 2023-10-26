namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updftcpoc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dil", "Cpoc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Cpoo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Faccl", "Cpoc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faccl", "Cpoc");
            DropColumn("dbo.Dil", "Cpoo");
            DropColumn("dbo.Dil", "Cpoc");
        }
    }
}
