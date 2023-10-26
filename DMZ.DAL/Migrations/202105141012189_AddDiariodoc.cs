namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiariodoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diariodoc",
                c => new
                    {
                        Diariodocstamp = c.String(nullable: false, maxLength: 80),
                        Diariostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Diariodocstamp)
                .ForeignKey("dbo.Diario", t => t.Diariostamp, cascadeDelete: true)
                .Index(t => t.Diariostamp);
            
            AddColumn("dbo.Rltusr", "Login", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Rltusr", "Codigo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rltusr", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropForeignKey("dbo.Diariodoc", "Diariostamp", "dbo.Diario");
            DropIndex("dbo.Diariodoc", new[] { "Diariostamp" });
            DropColumn("dbo.Rltusr", "Login");
            DropTable("dbo.Diariodoc");
        }
    }
}
