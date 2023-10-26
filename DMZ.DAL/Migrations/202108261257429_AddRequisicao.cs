namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequisicao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Di", "Requisicao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Requisicao", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facc", "Requisicao");
            DropColumn("dbo.Di", "Requisicao");
        }
    }
}
