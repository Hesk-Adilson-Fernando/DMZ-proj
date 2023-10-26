namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamIrps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "ContaIrps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "ContaIrpsdesc", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Apparam", "ContaIrps");
            DropColumn("dbo.Apparam", "ContaIrpsdesc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Apparam", "ContaIrpsdesc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Apparam", "ContaIrps", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Param", "ContaIrpsdesc");
            DropColumn("dbo.Param", "ContaIrps");
        }
    }
}
