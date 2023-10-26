namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInscricao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Inscricao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Inscricao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdi", "Inscricao");
            DropColumn("dbo.Fact", "Inscricao");
        }
    }
}
