namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRltcl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Nofnc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Fnc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "UsaMoeda", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "UsaMoeda");
            DropColumn("dbo.Cl", "Fnc");
            DropColumn("dbo.Cl", "Nofnc");
        }
    }
}
