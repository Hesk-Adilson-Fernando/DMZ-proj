namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updclDescricao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClFilial", "Descricao", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClFilial", "Descricao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
