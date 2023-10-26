namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdProdref : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Tipo", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.St", "Fornecedor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.St", "Fornecedor", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.St", "Tipo");
        }
    }
}
