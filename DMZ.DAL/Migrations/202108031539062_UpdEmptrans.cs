namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdEmptrans : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "Emptransporte", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Contaiva85", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Contaiva85desc", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Contaiva85desc");
            DropColumn("dbo.Param", "Contaiva85");
            DropColumn("dbo.Empresa", "Emptransporte");
        }
    }
}
