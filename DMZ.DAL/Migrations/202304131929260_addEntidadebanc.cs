namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEntidadebanc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "Entidadebanc", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contas", "Entidadebanc");
        }
    }
}
