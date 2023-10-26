namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RltAcadmiaUpd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "Mostraturma", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Mostraplanocur", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Mostradisciplina", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Mostraanosem", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Mostraprof", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "Mostraetapasem", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "Mostraetapasem");
            DropColumn("dbo.Rlt", "Mostraprof");
            DropColumn("dbo.Rlt", "Mostraanosem");
            DropColumn("dbo.Rlt", "Mostradisciplina");
            DropColumn("dbo.Rlt", "Mostraplanocur");
            DropColumn("dbo.Rlt", "Mostraturma");
        }
    }
}
