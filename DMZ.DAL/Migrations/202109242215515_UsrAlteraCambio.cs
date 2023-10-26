namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsrAlteraCambio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Alteracambio", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Alteracambio");
        }
    }
}
