namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updrltfiltrodatas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "FiltrosDatas", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Rlt", "Campotabela1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rlt", "Campotabela1", c => c.Boolean(nullable: false));
            DropColumn("dbo.Rlt", "FiltrosDatas");
        }
    }
}
