namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEntidfac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Entidadebanc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Referencia", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fact", "Referencia");
            DropColumn("dbo.Fact", "Entidadebanc");
        }
    }
}
