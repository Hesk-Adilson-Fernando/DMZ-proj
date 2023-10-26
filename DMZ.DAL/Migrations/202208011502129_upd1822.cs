namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upd1822 : DbMigration
    {
        public override void Up()
        {
           AddColumn("dbo.Param", "ImprimeMultDocumento", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "ImprimeMultDocumento");
        }
    }
}
