namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBombas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bico",
                c => new
                    {
                        Bicostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codigoconc = c.String(nullable: false, maxLength: 80),
                        Armazemstamp = c.String(nullable: false, maxLength: 80),
                        Armazem = c.String(nullable: false, maxLength: 80),
                        Combustivel = c.String(nullable: false, maxLength: 80),
                        Cor = c.String(nullable: false, maxLength: 80),
                        IipoCombustivel = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Encerrante = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.Bicostamp);
            
            CreateTable(
                "dbo.Bomba",
                c => new
                    {
                        Bombastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Modelo = c.String(nullable: false, maxLength: 80),
                        Fabricante = c.String(nullable: false, maxLength: 80),
                        Codmedicao = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totalizador = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Medicao = c.String(nullable: false, maxLength: 80),
                        Serie = c.String(nullable: false, maxLength: 80),
                        Armazemstamp = c.String(nullable: false, maxLength: 80),
                        Armazem = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Bombastamp);
            
            CreateTable(
                "dbo.BombaBico",
                c => new
                    {
                        BombaBicostamp = c.String(nullable: false, maxLength: 80),
                        Bombastamp = c.String(nullable: false, maxLength: 80),
                        Bicostamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        IipoCombustivel = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.BombaBicostamp)
                .ForeignKey("dbo.Bomba", t => t.Bombastamp, cascadeDelete: true)
                .Index(t => t.Bombastamp);
            
            AddColumn("dbo.Armazem", "Tanque", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BombaBico", "Bombastamp", "dbo.Bomba");
            DropIndex("dbo.BombaBico", new[] { "Bombastamp" });
            DropColumn("dbo.Armazem", "Tanque");
            DropTable("dbo.BombaBico");
            DropTable("dbo.Bomba");
            DropTable("dbo.Bico");
        }
    }
}
