namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProcessMesesstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proces", "Mesesstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Proces", "Mesesstamp");
        }
    }
}
