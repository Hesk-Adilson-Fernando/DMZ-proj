namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updParam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Prodenum", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Prodenum");
        }
    }
}
