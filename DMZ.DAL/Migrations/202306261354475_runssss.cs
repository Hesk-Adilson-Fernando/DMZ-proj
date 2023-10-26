namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class runssss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatriculaAluno",
                c => new
                    {
                        MatriculaAlunostamp = c.String(nullable: false, maxLength: 80),
                        Planopagstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Refonecedor = c.String(nullable: false, maxLength: 80),
                        Anolectivo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descplano = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Datapartida = c.DateTime(nullable: false),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        AnoSemstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sitcao = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Curso = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Datamat = c.DateTime(nullable: false),
                        Turno = c.String(nullable: false, maxLength: 80),
                        Periodo = c.String(nullable: false, maxLength: 80),
                        AnoSem = c.String(nullable: false, maxLength: 80),
                        Codtur = c.String(nullable: false, maxLength: 80),
                        Anolect = c.String(nullable: false, maxLength: 80),
                        Localmat = c.String(nullable: false, maxLength: 80),
                        Emails = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 400),
                        Gradestamp = c.String(nullable: false, maxLength: 80),
                        DescGrade = c.String(nullable: false, maxLength: 80),
                        Etapa = c.String(nullable: false, maxLength: 80),
                        Turmadiscstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        Turnostamp = c.String(nullable: false, maxLength: 80),
                        Codfac = c.String(nullable: false, maxLength: 80),
                        Alauxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Semstamp = c.String(nullable: false, maxLength: 80),
                        Nivelac = c.String(nullable: false, maxLength: 80),
                        Formaingresso = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Ccustostamp = c.String(nullable: false, maxLength: 80),
                        Coddep = c.String(nullable: false, maxLength: 80),
                        Departamento = c.String(nullable: false, maxLength: 80),
                        Faculdade = c.String(nullable: false, maxLength: 80),
                        Descanoaem = c.String(nullable: false, maxLength: 80),
                        Tipo = c.String(nullable: false, maxLength: 80),
                        Activo = c.Boolean(nullable: false),
                        Motivo = c.String(nullable: false, maxLength: 3000),
                    })
                .PrimaryKey(t => t.MatriculaAlunostamp);
            
            CreateTable(
                "dbo.DisciplinaTumra",
                c => new
                    {
                        DisciplinaTumrastamp = c.String(nullable: false, maxLength: 80),
                        Disciplina = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(nullable: false, maxLength: 80),
                        MatriculaAlunostamp = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Sitcao = c.String(nullable: false, maxLength: 80),
                        Activo = c.Boolean(nullable: false),
                        Motivo = c.String(nullable: false, maxLength: 3000),
                    })
                .PrimaryKey(t => t.DisciplinaTumrastamp)
                .ForeignKey("dbo.MatriculaAluno", t => t.MatriculaAlunostamp, cascadeDelete: true)
                .Index(t => t.MatriculaAlunostamp);
            
            CreateTable(
                "dbo.MatriculaTurmaAlunol",
                c => new
                    {
                        MatriculaTurmaAlunolstamp = c.String(nullable: false, maxLength: 80),
                        MatriculaAlunostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        AnoSemstamp = c.String(nullable: false, maxLength: 80),
                        Descanoaem = c.String(nullable: false, maxLength: 80),
                        Descurso = c.String(nullable: false, maxLength: 80),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        Descgrade = c.String(nullable: false, maxLength: 80),
                        Gradestamp = c.String(nullable: false, maxLength: 80),
                        Etapa = c.String(nullable: false, maxLength: 80),
                        Sala = c.String(nullable: false, maxLength: 80),
                        Turno = c.String(nullable: false, maxLength: 80),
                        Vagasmin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vagasmax = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Responsavel = c.String(nullable: false, maxLength: 80),
                        Responsavel2 = c.String(nullable: false, maxLength: 80),
                        Semanaslec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Horasaulas = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Formaaval = c.String(nullable: false, maxLength: 80),
                        Situacao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 2100),
                        Datain = c.DateTime(nullable: false),
                        Datafim = c.DateTime(nullable: false),
                        Horain = c.DateTime(nullable: false),
                        Horafim = c.DateTime(nullable: false),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        Turmadiscstamp = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MatriculaTurmaAlunolstamp)
                .ForeignKey("dbo.MatriculaAluno", t => t.MatriculaAlunostamp, cascadeDelete: true)
                .Index(t => t.MatriculaAlunostamp);
            
            AddColumn("dbo.Turma", "Codetapa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Turmal", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Turmal", "Motivo", c => c.String(nullable: false, maxLength: 3000));
            AddColumn("dbo.Turmanota", "Resultado", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Turmanota", "ResultadoFinal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Turmanota", "CodSit", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Turmanota", "Codetapa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Turmanota", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Turmanota", "Motivo", c => c.String(nullable: false, maxLength: 3000));
            AddColumn("dbo.Matdisc", "MatriculaAluno_MatriculaAlunostamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Param", "MatriculaComCCaberto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Planoavall", "DescexamNrmal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Planoavall", "DescexamRecor", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Turmanota", "Datafecho", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Matdisc", "MatriculaAluno_MatriculaAlunostamp");
            AddForeignKey("dbo.Matdisc", "MatriculaAluno_MatriculaAlunostamp", "dbo.MatriculaAluno", "MatriculaAlunostamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MatriculaTurmaAlunol", "MatriculaAlunostamp", "dbo.MatriculaAluno");
            DropForeignKey("dbo.Matdisc", "MatriculaAluno_MatriculaAlunostamp", "dbo.MatriculaAluno");
            DropForeignKey("dbo.DisciplinaTumra", "MatriculaAlunostamp", "dbo.MatriculaAluno");
            DropIndex("dbo.MatriculaTurmaAlunol", new[] { "MatriculaAlunostamp" });
            DropIndex("dbo.DisciplinaTumra", new[] { "MatriculaAlunostamp" });
            DropIndex("dbo.Matdisc", new[] { "MatriculaAluno_MatriculaAlunostamp" });
            AlterColumn("dbo.Turmanota", "Datafecho", c => c.Boolean(nullable: false));
            DropColumn("dbo.Planoavall", "DescexamRecor");
            DropColumn("dbo.Planoavall", "DescexamNrmal");
            DropColumn("dbo.Param", "MatriculaComCCaberto");
            DropColumn("dbo.Matdisc", "MatriculaAluno_MatriculaAlunostamp");
            DropColumn("dbo.Turmanota", "Motivo");
            DropColumn("dbo.Turmanota", "Activo");
            DropColumn("dbo.Turmanota", "Codetapa");
            DropColumn("dbo.Turmanota", "CodSit");
            DropColumn("dbo.Turmanota", "ResultadoFinal");
            DropColumn("dbo.Turmanota", "Resultado");
            DropColumn("dbo.Turmal", "Motivo");
            DropColumn("dbo.Turmal", "Activo");
            DropColumn("dbo.Turma", "Codetapa");
            DropTable("dbo.MatriculaTurmaAlunol");
            DropTable("dbo.DisciplinaTumra");
            DropTable("dbo.MatriculaAluno");
        }
    }
}
