namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPjescM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pjesc", "Mvalival", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Mdescontol", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Msubtotall", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pjesc", "Mtotall", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pjesc", "Mtotall");
            DropColumn("dbo.Pjesc", "Msubtotall");
            DropColumn("dbo.Pjesc", "Mdescontol");
            DropColumn("dbo.Pjesc", "Mvalival");
        }
    }
}
