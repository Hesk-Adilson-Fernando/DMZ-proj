namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updtdiStkinicial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdi", "Stkinicial", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdi", "Stkinicial");
        }
    }
}
