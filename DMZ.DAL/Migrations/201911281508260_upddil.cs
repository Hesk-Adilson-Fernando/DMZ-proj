namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upddil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dil", "Descarm", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dil", "Descarm");
        }
    }
}
