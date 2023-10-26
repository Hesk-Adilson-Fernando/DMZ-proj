namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterparamintegradoc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "Ncobrigadoc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Integradocs", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Integradocs");
            DropColumn("dbo.Tdoc", "Ncobrigadoc");
        }
    }
}
