namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updTurmalno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmal", "No", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turmal", "No");
        }
    }
}
