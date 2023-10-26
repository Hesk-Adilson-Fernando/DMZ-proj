namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updTurmadiscpStstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turmadiscp", "Ststamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turmadiscp", "Ststamp");
        }
    }
}
