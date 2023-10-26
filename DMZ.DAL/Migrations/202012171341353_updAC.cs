namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updAC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anolectivo",
                c => new
                    {
                        Anolectivostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 250),
                        Inicio = c.DateTime(nullable: false),
                        Fim = c.DateTime(nullable: false),
                        Encerrado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Anolectivostamp);
            
            CreateTable(
                "dbo.Feriado",
                c => new
                    {
                        Feriadostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Academico = c.Boolean(nullable: false),
                        Biblioteca = c.Boolean(nullable: false),
                        Administrativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Feriadostamp);
            
            CreateTable(
                "dbo.Feriadol",
                c => new
                    {
                        Feriadolstamp = c.String(nullable: false, maxLength: 80),
                        Feriadostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Feriadolstamp)
                .ForeignKey("dbo.Feriado", t => t.Feriadostamp, cascadeDelete: true)
                .Index(t => t.Feriadostamp);
            
            CreateTable(
                "dbo.Paramac",
                c => new
                    {
                        Paramacstamp = c.String(nullable: false, maxLength: 80),
                        AnoLectivo = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Paramacstamp);
            
            CreateTable(
                "dbo.Unidensino",
                c => new
                    {
                        Unidensinostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Morada = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Unidensinostamp);
            
            CreateTable(
                "dbo.Unidensinol",
                c => new
                    {
                        Unidensinolstamp = c.String(nullable: false, maxLength: 80),
                        Unidensinostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Unidensinolstamp)
                .ForeignKey("dbo.Unidensino", t => t.Unidensinostamp, cascadeDelete: true)
                .Index(t => t.Unidensinostamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Unidensinol", "Unidensinostamp", "dbo.Unidensino");
            DropForeignKey("dbo.Feriadol", "Feriadostamp", "dbo.Feriado");
            DropIndex("dbo.Unidensinol", new[] { "Unidensinostamp" });
            DropIndex("dbo.Feriadol", new[] { "Feriadostamp" });
            DropTable("dbo.Unidensinol");
            DropTable("dbo.Unidensino");
            DropTable("dbo.Paramac");
            DropTable("dbo.Feriadol");
            DropTable("dbo.Feriado");
            DropTable("dbo.Anolectivo");
        }
    }
}
