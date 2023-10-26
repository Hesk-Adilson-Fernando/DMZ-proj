namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfamcodigo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Familiapb", "Codigo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Familiapb", "Codigo");
        }
    }
}
