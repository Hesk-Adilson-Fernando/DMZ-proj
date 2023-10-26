namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updcl2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Localidade", c => c.String(maxLength: 80));
            AddColumn("dbo.Cl", "Distrito", c => c.String(maxLength: 80));
            AddColumn("dbo.Cl", "Provincia", c => c.String(maxLength: 80));
            AlterColumn("dbo.Cl", "Status", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cl", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Cl", "Provincia");
            DropColumn("dbo.Cl", "Distrito");
            DropColumn("dbo.Cl", "Localidade");
        }
    }
}
