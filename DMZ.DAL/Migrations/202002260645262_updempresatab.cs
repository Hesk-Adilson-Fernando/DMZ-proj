namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updempresatab : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "LogoGrande", c => c.Boolean(nullable: false));
            AddColumn("dbo.Empresa", "MostraNome", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresa", "MostraNome");
            DropColumn("dbo.Empresa", "LogoGrande");
        }
    }
}
