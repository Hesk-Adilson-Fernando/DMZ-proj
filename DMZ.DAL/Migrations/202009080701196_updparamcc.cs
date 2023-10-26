namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparamcc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "CriaContacc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "CriaContacc");
        }
    }
}
