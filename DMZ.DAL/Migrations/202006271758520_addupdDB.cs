namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addupdDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teste", "descricao2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Teste", "Descricao2", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teste", "Descricao2", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Teste", "descricao2", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
