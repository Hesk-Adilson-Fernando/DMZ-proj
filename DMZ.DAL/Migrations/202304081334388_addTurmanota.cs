namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTurmanota : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turmanota",
                c => new
                    {
                        Turmanotastamp = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Alunostamp = c.String(nullable: false, maxLength: 80),
                        AlunoNome = c.String(nullable: false, maxLength: 80),
                        N1 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        N2 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        N3 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        N4 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        N5 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Media = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Aprovado = c.Boolean(nullable: false),
                        Coddis = c.String(nullable: false, maxLength: 80),
                        Disciplina = c.String(nullable: false, maxLength: 80),
                        Anosem = c.String(nullable: false, maxLength: 80),
                        Sem = c.String(nullable: false, maxLength: 80),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        E1 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        E2 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Es = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mediafinal = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Profnome = c.String(nullable: false, maxLength: 80),
                        Pestamp2 = c.String(nullable: false, maxLength: 80),
                        Profnome2 = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Turmanotastamp)
                .ForeignKey("dbo.Turma", t => t.Turmastamp, cascadeDelete: true)
                .Index(t => t.Turmastamp);
            
            DropTable("dbo.Lnota");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Lnota",
                c => new
                    {
                        Lnotastamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Nota1 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nota2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nota3 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nota4 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nota5 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Media = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        Aprovado = c.Boolean(nullable: false),
                        Coddis = c.String(nullable: false, maxLength: 80),
                        Disc = c.String(nullable: false, maxLength: 80),
                        Codsem = c.String(nullable: false, maxLength: 80),
                        Sem = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Curso = c.String(nullable: false, maxLength: 80),
                        Turma = c.String(nullable: false, maxLength: 80),
                        Exame1 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Exame2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Examespecial = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mediafinal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Credac = c.Boolean(nullable: false),
                        Inst = c.String(nullable: false, maxLength: 80),
                        Codinst = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 500),
                        Codprof = c.String(nullable: false, maxLength: 80),
                        Prof = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Lnotastamp);
            
            DropForeignKey("dbo.Turmanota", "Turmastamp", "dbo.Turma");
            DropIndex("dbo.Turmanota", new[] { "Turmastamp" });
            DropTable("dbo.Turmanota");
        }
    }
}
