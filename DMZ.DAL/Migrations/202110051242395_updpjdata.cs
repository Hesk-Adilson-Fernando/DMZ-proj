namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updpjdata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pj", "Data", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pj", "Datini");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pj", "Datini", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pj", "Data");
        }
    }
}
