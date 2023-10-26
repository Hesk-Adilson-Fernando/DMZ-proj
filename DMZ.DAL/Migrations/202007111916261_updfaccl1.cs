namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfaccl1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faccl", "Oristampl", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faccl", "Oristampl");
        }
    }
}
