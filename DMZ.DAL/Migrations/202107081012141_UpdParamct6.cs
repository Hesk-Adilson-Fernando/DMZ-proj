namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamct6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Integracaoautomatica", c => c.Boolean(nullable: false));
            DropColumn("dbo.Param", "CriaContascl");
            DropColumn("dbo.Param", "CriaContasfnc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Param", "CriaContasfnc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "CriaContascl", c => c.Boolean(nullable: false));
            DropColumn("dbo.Param", "Integracaoautomatica");
        }
    }
}
