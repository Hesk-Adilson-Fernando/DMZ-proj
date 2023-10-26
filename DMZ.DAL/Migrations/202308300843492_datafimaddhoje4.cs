namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datafimaddhoje4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planopag", "Datafim", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planopag", "Datafim");
        }
    }
}
