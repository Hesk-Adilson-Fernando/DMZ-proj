namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPgc2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pgc", "oristamp", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pgc", "oristamp", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
