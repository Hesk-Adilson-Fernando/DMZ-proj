namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter20222 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Cl", "Campo1");
            //DropColumn("dbo.Cl", "Campo2");
            //DropColumn("dbo.Fnc", "Campo1");
            //DropColumn("dbo.Fnc", "Campo2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fnc", "Campo2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fnc", "Campo1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Campo2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Campo1", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
