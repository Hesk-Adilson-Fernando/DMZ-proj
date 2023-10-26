namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMotorista : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Motorista",
                c => new
                    {
                        Motoristastamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Motoristastamp);
            
            CreateTable(
                "dbo.Motoristal",
                c => new
                    {
                        Motoristalstamp = c.String(nullable: false, maxLength: 80),
                        Motoristastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Motoristalstamp)
                .ForeignKey("dbo.Motorista", t => t.Motoristastamp, cascadeDelete: true)
                .Index(t => t.Motoristastamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Motoristal", "Motoristastamp", "dbo.Motorista");
            DropIndex("dbo.Motoristal", new[] { "Motoristastamp" });
            DropTable("dbo.Motoristal");
            DropTable("dbo.Motorista");
        }
    }
}
