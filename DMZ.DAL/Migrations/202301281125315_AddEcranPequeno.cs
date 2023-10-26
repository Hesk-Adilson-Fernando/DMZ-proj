namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEcranPequeno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "EcranPosPequeno", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "EcranPosPequeno");
        }
    }
}
