namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNomefile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "Nomfile3", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdoc", "Nomfile3");
        }
    }
}
