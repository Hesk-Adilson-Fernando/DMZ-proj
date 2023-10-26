namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updpr1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Modeloja", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Modeloja");
        }
    }
}
