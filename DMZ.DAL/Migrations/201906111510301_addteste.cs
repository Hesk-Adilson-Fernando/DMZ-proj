namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addteste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teste",
                c => new
                    {
                        Testestamp = c.String(nullable: false, maxLength: 80),
                        descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Testestamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teste");
        }
    }
}
