namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclling : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClLing",
                c => new
                    {
                        ClLingstamp = c.String(nullable: false, maxLength: 80),
                        Lingua = c.String(nullable: false, maxLength: 80),
                        Fala = c.String(nullable: false, maxLength: 80),
                        Leitura = c.String(nullable: false, maxLength: 80),
                        Escrita = c.String(nullable: false, maxLength: 80),
                        Compreecao = c.String(nullable: false, maxLength: 80),
                        Materna = c.Boolean(nullable: false),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.ClLingstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClLing", "Clstamp", "dbo.Cl");
            DropIndex("dbo.ClLing", new[] { "Clstamp" });
            DropTable("dbo.ClLing");
        }
    }
}
