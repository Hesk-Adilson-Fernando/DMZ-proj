namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterparametros : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Codsrc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Codactivo", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Param", "Usamascfact");
            DropColumn("dbo.Param", "Usaradicalfact");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Param", "Usaradicalfact", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Usamascfact", c => c.Boolean(nullable: false));
            DropColumn("dbo.Param", "Codactivo");
            DropColumn("dbo.Param", "Codsrc");
        }
    }
}
