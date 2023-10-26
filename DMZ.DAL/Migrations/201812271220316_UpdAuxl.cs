namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdAuxl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auxiliar", "Padrao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auxiliar", "Padrao");
        }
    }
}
