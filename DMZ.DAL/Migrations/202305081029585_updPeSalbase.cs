namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPeSalbase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PeSalbase", "Mes", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.PeSalbase", "Mesesstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PeSalbase", "Mesesstamp");
            DropColumn("dbo.PeSalbase", "Mes");
        }
    }
}
