namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PedescExcluiProc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedesc", "ExcluiProc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pedesc", "ExcluiProc");
        }
    }
}
