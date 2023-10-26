namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datafimaddhoje2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Planopag", "Datafim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Planopag", "Datafim", c => c.DateTime(nullable: false));
        }
    }
}
