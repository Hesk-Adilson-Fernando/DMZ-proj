namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdfactDataentrega : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fact", "Datapartida", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fact", "Datapartida", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
