namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclfnccamps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dil", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Codccu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Contastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "Mostrapj", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fnc", "Contastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Mostraccusto", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Mostraccusto");
            DropColumn("dbo.Fnc", "Contastamp");
            DropColumn("dbo.Rlt", "Mostrapj");
            DropColumn("dbo.Cl", "Contastamp");
            DropColumn("dbo.Dil", "Codccu");
            DropColumn("dbo.Dil", "Ccusto");
        }
    }
}
