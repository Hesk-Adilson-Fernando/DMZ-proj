namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class runsssss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Dispensa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Exclui", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Exclui");
            DropColumn("dbo.Param", "Dispensa");
        }
    }
}
