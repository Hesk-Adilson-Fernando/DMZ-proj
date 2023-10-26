namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdAccess : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usracessos", "Origem", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usracessos", "Origem");
        }
    }
}
