namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfp2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formasp", "Banco2", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formasp", "Banco2");
        }
    }
}
