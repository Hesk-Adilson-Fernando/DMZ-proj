namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamPj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Naomostradatain", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Naomostradatater", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Naomostraduracao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Naomostraduracao");
            DropColumn("dbo.Param", "Naomostradatater");
            DropColumn("dbo.Param", "Naomostradatain");
        }
    }
}
