namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPeSalbase2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeSalbase", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeSalbase", "Usrstamp");
        }
    }
}
