namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updcl21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Tipo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cl", "Tipo");
        }
    }
}
