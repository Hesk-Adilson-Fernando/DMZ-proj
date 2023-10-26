namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPrcTotais : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "TotalAliment", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalHextra", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalFaltas", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalSindicato", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "SegSocfunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "Linhatotal", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Prc", "Linhatotal");
            DropColumn("dbo.Prc", "SegSocfunc");
            DropColumn("dbo.Prc", "TotalSindicato");
            DropColumn("dbo.Prc", "TotalFaltas");
            DropColumn("dbo.Prc", "TotalHextra");
            DropColumn("dbo.Prc", "TotalAliment");
        }
    }
}
