namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class del_teste : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Teste");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Teste",
                c => new
                    {
                        Testestamp = c.String(nullable: false, maxLength: 80),
                        descricao = c.String(nullable: false, maxLength: 80),
                        Descricao2 = c.String(nullable: false, maxLength: 200),
                        descricao2 = c.String(nullable: false, maxLength: 80),
                        NumDecimal = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Testestamp);
            
        }
    }
}
