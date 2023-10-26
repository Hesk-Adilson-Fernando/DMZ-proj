namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter20221 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Param", "Param1");
            //DropColumn("dbo.Param", "Mostraccu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Param", "Mostraccu", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Param1", c => c.Boolean(nullable: false));
        }
    }
}
