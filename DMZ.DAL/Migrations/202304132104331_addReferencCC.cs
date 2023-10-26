namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReferencCC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cc", "Entidadebanc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cc", "Referencia", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cc", "Referencia");
            DropColumn("dbo.Cc", "Entidadebanc");
        }
    }
}
