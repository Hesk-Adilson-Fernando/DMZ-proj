namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codtz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Codtz",
                c => new
                    {
                        Codtzstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Codtzstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Codtz");
        }
    }
}
