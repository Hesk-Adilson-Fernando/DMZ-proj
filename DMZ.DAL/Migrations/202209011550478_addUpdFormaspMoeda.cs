namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUpdFormaspMoeda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formasp", "Moeda", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formasp", "Moeda");
        }
    }
}
