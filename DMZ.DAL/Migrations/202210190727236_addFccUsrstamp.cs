namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFccUsrstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fcc", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fcc", "Usrstamp");
        }
    }
}
