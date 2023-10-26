namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updperclprosc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Percl", "Processtamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Percl", "Processtamp");
        }
    }
}
