namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ccu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CCu",
                c => new
                    {
                        Ccustamp = c.String(nullable: false, maxLength: 80),
                        CodCcu = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Defeito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ccustamp);
            
            CreateTable(
                "dbo.Ccu_Arm",
                c => new
                    {
                        Ccu_Armstamp = c.String(nullable: false, maxLength: 80),
                        Ccustamp = c.String(maxLength: 80),
                        Codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Defeito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ccu_Armstamp)
                .ForeignKey("dbo.CCu", t => t.Ccustamp)
                .Index(t => t.Ccustamp);
            
            CreateTable(
                "dbo.Ccu_Caixa",
                c => new
                    {
                        Ccu_Caixastamp = c.String(nullable: false, maxLength: 80),
                        Ccustamp = c.String(maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Banco = c.String(maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Defeito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ccu_Caixastamp)
                .ForeignKey("dbo.CCu", t => t.Ccustamp)
                .Index(t => t.Ccustamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ccu_Caixa", "Ccustamp", "dbo.CCu");
            DropForeignKey("dbo.Ccu_Arm", "Ccustamp", "dbo.CCu");
            DropIndex("dbo.Ccu_Caixa", new[] { "Ccustamp" });
            DropIndex("dbo.Ccu_Arm", new[] { "Ccustamp" });
            DropTable("dbo.Ccu_Caixa");
            DropTable("dbo.Ccu_Arm");
            DropTable("dbo.CCu");
        }
    }
}
