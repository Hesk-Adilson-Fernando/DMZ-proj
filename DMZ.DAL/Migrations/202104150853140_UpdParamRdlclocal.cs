namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamRdlclocal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Localrdlc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Localrdlc");
        }
    }
}
