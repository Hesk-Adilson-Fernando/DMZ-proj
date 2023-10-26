namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAcademia : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cursem", "Cursconfig_Cursconfigstamp", "dbo.Cursconfig");
            DropForeignKey("dbo.Cursemdisc", "Cursemstamp", "dbo.Cursem");
            DropForeignKey("dbo.Discl", "Discstamp", "dbo.Disc");
            DropForeignKey("dbo.Turhl", "Turhstamp", "dbo.Turh");
            DropForeignKey("dbo.Unidensinol", "Unidensinostamp", "dbo.Unidensino");
            DropIndex("dbo.Cursem", new[] { "Cursconfig_Cursconfigstamp" });
            DropIndex("dbo.Cursemdisc", new[] { "Cursemstamp" });
            DropIndex("dbo.Discl", new[] { "Discstamp" });
            DropIndex("dbo.Turhl", new[] { "Turhstamp" });
            DropIndex("dbo.Unidensinol", new[] { "Unidensinostamp" });
            //CreateTable(
            //    "dbo.AnoLectivo",
            //    c => new
            //        {
            //            AnoLectivostamp = c.String(nullable: false, maxLength: 80),
            //            Codigo = c.String(nullable: false, maxLength: 80),
            //            Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
            //            Descricao = c.String(nullable: false, maxLength: 80),
            //        })
            //    .PrimaryKey(t => t.AnoLectivostamp);
            
            CreateTable(
                "dbo.AnoSem",
                c => new
                    {
                        AnoSemstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 2100),
                    })
                .PrimaryKey(t => t.AnoSemstamp);
            
            CreateTable(
                "dbo.Turma",
                c => new
                    {
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        AnoSemstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
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
                    })
                .PrimaryKey(t => t.Turmastamp)
                .ForeignKey("dbo.AnoSem", t => t.AnoSemstamp, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.Cursostamp, cascadeDelete: true)
                .Index(t => t.AnoSemstamp)
                .Index(t => t.Cursostamp);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Desccurso = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Status = c.String(nullable: false, maxLength: 80),
                        Nivel = c.String(nullable: false, maxLength: 80),
                        Nivelstamp = c.String(nullable: false, maxLength: 80),
                        Cargahora = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Cursoeq = c.String(nullable: false, maxLength: 80),
                        Duracao = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Codmec = c.String(nullable: false, maxLength: 80),
                        Habmec = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 2100),
                        Imagem = c.Binary(),
                        CCusto = c.String(nullable: false, maxLength: 80),
                        Ccustamp = c.String(nullable: false, maxLength: 80),
                        Ccudepstamp = c.String(nullable: false, maxLength: 80),
                        Departamento = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Cursostamp);
            
            CreateTable(
                "dbo.Cursoacto",
                c => new
                    {
                        Cursoactostamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Anosem = c.String(nullable: false, maxLength: 80),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Cursoactostamp)
                .ForeignKey("dbo.Curso", t => t.Cursostamp, cascadeDelete: true)
                .Index(t => t.Cursostamp);
            
            CreateTable(
                "dbo.Cursodoc",
                c => new
                    {
                        Cursodocstamp = c.String(nullable: false, maxLength: 80),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        Documento = c.String(nullable: false, maxLength: 80),
                        Anexo = c.Binary(),
                    })
                .PrimaryKey(t => t.Cursodocstamp)
                .ForeignKey("dbo.Curso", t => t.Cursostamp, cascadeDelete: true)
                .Index(t => t.Cursostamp);
            
            CreateTable(
                "dbo.Cursograd",
                c => new
                    {
                        Cursogradstamp = c.String(nullable: false, maxLength: 80),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        Gradestamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Principal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Cursogradstamp)
                .ForeignKey("dbo.Curso", t => t.Cursostamp, cascadeDelete: true)
                .Index(t => t.Cursostamp);
            
            CreateTable(
                "dbo.Turmadisc",
                c => new
                    {
                        Turmadiscstamp = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(nullable: false, maxLength: 80),
                        Disciplina = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Turmadiscstamp)
                .ForeignKey("dbo.Turma", t => t.Turmastamp, cascadeDelete: true)
                .Index(t => t.Turmastamp);
            
            CreateTable(
                "dbo.Turmadiscp",
                c => new
                    {
                        Turmadiscpstamp = c.String(nullable: false, maxLength: 80),
                        Turmadiscstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Turmadiscpstamp)
                .ForeignKey("dbo.Turmadisc", t => t.Turmadiscstamp, cascadeDelete: true)
                .Index(t => t.Turmadiscstamp);
            
            CreateTable(
                "dbo.Turmal",
                c => new
                    {
                        Turmalstamp = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Turmalstamp)
                .ForeignKey("dbo.Turma", t => t.Turmastamp, cascadeDelete: true)
                .Index(t => t.Turmastamp);
            
            CreateTable(
                "dbo.Ccudep",
                c => new
                    {
                        Ccudepstamp = c.String(nullable: false, maxLength: 80),
                        Ccustamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Ccudepstamp)
                .ForeignKey("dbo.CCu", t => t.Ccustamp, cascadeDelete: true)
                .Index(t => t.Ccustamp);
            
            CreateTable(
                "dbo.Docac",
                c => new
                    {
                        Docacstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Docacstamp);
            
            CreateTable(
                "dbo.Fing",
                c => new
                    {
                        Fingstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Fingstamp);
            
            CreateTable(
                "dbo.Grade",
                c => new
                    {
                        Gradestamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Desccurso = c.String(nullable: false, maxLength: 80),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        Activo = c.Boolean(nullable: false),
                        Anoseminic = c.String(nullable: false, maxLength: 80),
                        AnoSemstamp = c.String(nullable: false, maxLength: 80),
                        TotalCargahora = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Obs = c.String(nullable: false, maxLength: 2100),
                        Totaldisc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TotalCreda = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Gradestamp);
            
            CreateTable(
                "dbo.Gradel",
                c => new
                    {
                        Gradelstamp = c.String(nullable: false, maxLength: 80),
                        Gradestamp = c.String(nullable: false, maxLength: 80),
                        Codetapa = c.String(nullable: false, maxLength: 80),
                        Etapa = c.String(nullable: false, maxLength: 80),
                        Coddisc = c.String(nullable: false, maxLength: 80),
                        Displina = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Semstamp = c.String(nullable: false, maxLength: 80),
                        Categoria = c.String(nullable: false, maxLength: 80),
                        Opcao = c.Boolean(nullable: false),
                        Credac = c.Decimal(nullable: false, precision: 6, scale: 2),
                        Cargahtotal = c.Decimal(nullable: false, precision: 6, scale: 2),
                        Cargahteorica = c.Decimal(nullable: false, precision: 6, scale: 2),
                        Cargahpratica = c.Decimal(nullable: false, precision: 6, scale: 2),
                        Prec = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Gradelstamp)
                .ForeignKey("dbo.Grade", t => t.Gradestamp, cascadeDelete: true)
                .ForeignKey("dbo.Sem", t => t.Semstamp, cascadeDelete: true)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Gradestamp)
                .Index(t => t.Ststamp)
                .Index(t => t.Semstamp);
            
            CreateTable(
                "dbo.Sem",
                c => new
                    {
                        Semstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Semstamp);
            
            CreateTable(
                "dbo.Stb",
                c => new
                    {
                        Stbstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 2100),
                    })
                .PrimaryKey(t => t.Stbstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.Stl",
                c => new
                    {
                        Stlstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Stlstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.Horario",
                c => new
                    {
                        Horariostamp = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        Turma = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Anosem = c.String(nullable: false, maxLength: 80),
                        Visualizar = c.Boolean(nullable: false),
                        Hactivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Horariostamp);
            
            CreateTable(
                "dbo.Horariol",
                c => new
                    {
                        Horariolstamp = c.String(nullable: false, maxLength: 80),
                        Horariostamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Hora = c.String(nullable: false, maxLength: 80),
                        Segunda = c.String(nullable: false, maxLength: 80),
                        Terca = c.String(nullable: false, maxLength: 80),
                        Quarta = c.String(nullable: false, maxLength: 80),
                        Quinta = c.String(nullable: false, maxLength: 80),
                        Sexta = c.String(nullable: false, maxLength: 80),
                        Sabado = c.String(nullable: false, maxLength: 80),
                        Domingo = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Horariolstamp)
                .ForeignKey("dbo.Horario", t => t.Horariostamp, cascadeDelete: true)
                .Index(t => t.Horariostamp);
            
            CreateTable(
                "dbo.Planopag",
                c => new
                    {
                        Planopagstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Parcelas = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Anosem = c.String(nullable: false, maxLength: 80),
                        Anolectivo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Valorextra = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Desconto = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Valorparzero = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Datapartida = c.DateTime(nullable: false),
                        Diauteis = c.Boolean(nullable: false),
                        Pularsabados = c.Boolean(nullable: false),
                        Pulardomingos = c.Boolean(nullable: false),
                        Pularferiados = c.Boolean(nullable: false),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Distrato = c.Boolean(nullable: false),
                        Valordistrato = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Diasvenc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TipoValdistrato = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descdistrato = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Planopagstamp);
            
            CreateTable(
                "dbo.Planopagp",
                c => new
                    {
                        Planopagpstamp = c.String(nullable: false, maxLength: 80),
                        Planopagstamp = c.String(nullable: false, maxLength: 80),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Parecela = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valorbruto = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Valordesc = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Valorextra = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Valordescextra = c.Decimal(nullable: false, precision: 16, scale: 0),
                        ValorTotal = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Pzerro = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Planopagpstamp)
                .ForeignKey("dbo.Planopag", t => t.Planopagstamp, cascadeDelete: true)
                .Index(t => t.Planopagstamp);
            
            CreateTable(
                "dbo.Planopagt",
                c => new
                    {
                        Planopagtstamp = c.String(nullable: false, maxLength: 80),
                        Planopagstamp = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Codturma = c.String(nullable: false, maxLength: 80),
                        Descturma = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Planopagtstamp)
                .ForeignKey("dbo.Planopag", t => t.Planopagstamp, cascadeDelete: true)
                .Index(t => t.Planopagstamp);
            
            CreateTable(
                "dbo.Pedisc",
                c => new
                    {
                        Pediscstamp = c.String(nullable: false, maxLength: 80),
                        Disciplina = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pediscstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Planobolsa",
                c => new
                    {
                        Planobolsastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Perc = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Condicional = c.Boolean(nullable: false),
                        Tipodesc = c.String(nullable: false, maxLength: 80),
                        Accao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Planobolsastamp);
            
            CreateTable(
                "dbo.Planomulta",
                c => new
                    {
                        Planomultastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Perc = c.Decimal(nullable: false, precision: 16, scale: 0),
                        Condicional = c.Boolean(nullable: false),
                        Tipodesc = c.String(nullable: false, maxLength: 80),
                        Accao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Planomultastamp);
            
            CreateTable(
                "dbo.Sala",
                c => new
                    {
                        Salastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Capacidade = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Salastamp);
            
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        Turnostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Horain = c.DateTime(nullable: false),
                        Horafim = c.DateTime(nullable: false),
                        Intervaloin = c.DateTime(nullable: false),
                        Intervalofim = c.DateTime(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 2100),
                    })
                .PrimaryKey(t => t.Turnostamp);
            
            AddColumn("dbo.Cl", "Ccustostamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Sigla", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Credac", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.St", "Cargahtotal", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.St", "Cargahteorica", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.St", "Cargahpratica", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.St", "Prec", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Cl", "Codcurso", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Cl", "Codfac", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.St", "Obs", c => c.String(nullable: false));
            DropTable("dbo.Anolectivo");
            DropTable("dbo.Cursconfig");
            DropTable("dbo.Cursem");
            DropTable("dbo.Cursemdisc");
            DropTable("dbo.Disc");
            DropTable("dbo.Discl");
            DropTable("dbo.Turh");
            DropTable("dbo.Turhl");
            DropTable("dbo.Unidensino");
            DropTable("dbo.Unidensinol");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Unidensinol",
                c => new
                    {
                        Unidensinolstamp = c.String(nullable: false, maxLength: 80),
                        Unidensinostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Unidensinolstamp);
            
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
                "dbo.Turhl",
                c => new
                    {
                        Turhlstamp = c.String(nullable: false, maxLength: 80),
                        Turhstamp = c.String(nullable: false, maxLength: 80),
                        Hora = c.String(nullable: false, maxLength: 80),
                        Segunda = c.String(nullable: false, maxLength: 80),
                        Terca = c.String(nullable: false, maxLength: 80),
                        Quarta = c.String(nullable: false, maxLength: 80),
                        Quinta = c.String(nullable: false, maxLength: 80),
                        Sexta = c.String(nullable: false, maxLength: 80),
                        Sabado = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Turhlstamp);
            
            CreateTable(
                "dbo.Turh",
                c => new
                    {
                        Turhstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Curso = c.String(nullable: false, maxLength: 80),
                        Codsem = c.String(nullable: false, maxLength: 80),
                        Sem = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Tur = c.String(nullable: false, maxLength: 80),
                        Codtur = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Turhstamp);
            
            CreateTable(
                "dbo.Discl",
                c => new
                    {
                        Disclstamp = c.String(nullable: false, maxLength: 80),
                        Discstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Disclstamp);
            
            CreateTable(
                "dbo.Disc",
                c => new
                    {
                        Discstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cargah = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prec = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Discstamp);
            
            CreateTable(
                "dbo.Cursemdisc",
                c => new
                    {
                        Cursemdiscstamp = c.String(nullable: false, maxLength: 80),
                        Cursemstamp = c.String(nullable: false, maxLength: 80),
                        Coddisc = c.String(nullable: false, maxLength: 80),
                        Descdisc = c.String(nullable: false, maxLength: 80),
                        Cursconfigstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Cursemdiscstamp);
            
            CreateTable(
                "dbo.Cursem",
                c => new
                    {
                        Cursemstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Cursoconfigstamp = c.String(nullable: false, maxLength: 80),
                        Cursconfig_Cursconfigstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Cursemstamp);
            
            CreateTable(
                "dbo.Cursconfig",
                c => new
                    {
                        Cursconfigstamp = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Desccurso = c.String(nullable: false, maxLength: 80),
                        Descstatus = c.String(nullable: false, maxLength: 80),
                        Codstatus = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Cursconfigstamp);
            
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
            
            DropForeignKey("dbo.Pedisc", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Planopagt", "Planopagstamp", "dbo.Planopag");
            DropForeignKey("dbo.Planopagp", "Planopagstamp", "dbo.Planopag");
            DropForeignKey("dbo.Horariol", "Horariostamp", "dbo.Horario");
            DropForeignKey("dbo.Stl", "Ststamp", "dbo.St");
            DropForeignKey("dbo.Stb", "Ststamp", "dbo.St");
            DropForeignKey("dbo.Gradel", "Ststamp", "dbo.St");
            DropForeignKey("dbo.Gradel", "Semstamp", "dbo.Sem");
            DropForeignKey("dbo.Gradel", "Gradestamp", "dbo.Grade");
            DropForeignKey("dbo.Ccudep", "Ccustamp", "dbo.CCu");
            DropForeignKey("dbo.Turmal", "Turmastamp", "dbo.Turma");
            DropForeignKey("dbo.Turmadiscp", "Turmadiscstamp", "dbo.Turmadisc");
            DropForeignKey("dbo.Turmadisc", "Turmastamp", "dbo.Turma");
            DropForeignKey("dbo.Turma", "Cursostamp", "dbo.Curso");
            DropForeignKey("dbo.Cursograd", "Cursostamp", "dbo.Curso");
            DropForeignKey("dbo.Cursodoc", "Cursostamp", "dbo.Curso");
            DropForeignKey("dbo.Cursoacto", "Cursostamp", "dbo.Curso");
            DropForeignKey("dbo.Turma", "AnoSemstamp", "dbo.AnoSem");
            DropIndex("dbo.Pedisc", new[] { "Pestamp" });
            DropIndex("dbo.Planopagt", new[] { "Planopagstamp" });
            DropIndex("dbo.Planopagp", new[] { "Planopagstamp" });
            DropIndex("dbo.Horariol", new[] { "Horariostamp" });
            DropIndex("dbo.Stl", new[] { "Ststamp" });
            DropIndex("dbo.Stb", new[] { "Ststamp" });
            DropIndex("dbo.Gradel", new[] { "Semstamp" });
            DropIndex("dbo.Gradel", new[] { "Ststamp" });
            DropIndex("dbo.Gradel", new[] { "Gradestamp" });
            DropIndex("dbo.Ccudep", new[] { "Ccustamp" });
            DropIndex("dbo.Turmal", new[] { "Turmastamp" });
            DropIndex("dbo.Turmadiscp", new[] { "Turmadiscstamp" });
            DropIndex("dbo.Turmadisc", new[] { "Turmastamp" });
            DropIndex("dbo.Cursograd", new[] { "Cursostamp" });
            DropIndex("dbo.Cursodoc", new[] { "Cursostamp" });
            DropIndex("dbo.Cursoacto", new[] { "Cursostamp" });
            DropIndex("dbo.Turma", new[] { "Cursostamp" });
            DropIndex("dbo.Turma", new[] { "AnoSemstamp" });
            AlterColumn("dbo.St", "Obs", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Cl", "Codfac", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Cl", "Codcurso", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.St", "Prec");
            DropColumn("dbo.St", "Cargahpratica");
            DropColumn("dbo.St", "Cargahteorica");
            DropColumn("dbo.St", "Cargahtotal");
            DropColumn("dbo.St", "Credac");
            DropColumn("dbo.St", "Sigla");
            DropColumn("dbo.Cl", "Contasstamp");
            DropColumn("dbo.Cl", "Ccustostamp");
            DropTable("dbo.Turno");
            DropTable("dbo.Sala");
            DropTable("dbo.Planomulta");
            DropTable("dbo.Planobolsa");
            DropTable("dbo.Pedisc");
            DropTable("dbo.Planopagt");
            DropTable("dbo.Planopagp");
            DropTable("dbo.Planopag");
            DropTable("dbo.Horariol");
            DropTable("dbo.Horario");
            DropTable("dbo.Stl");
            DropTable("dbo.Stb");
            DropTable("dbo.Sem");
            DropTable("dbo.Gradel");
            DropTable("dbo.Grade");
            DropTable("dbo.Fing");
            DropTable("dbo.Docac");
            DropTable("dbo.Ccudep");
            DropTable("dbo.Turmal");
            DropTable("dbo.Turmadiscp");
            DropTable("dbo.Turmadisc");
            DropTable("dbo.Cursograd");
            DropTable("dbo.Cursodoc");
            DropTable("dbo.Cursoacto");
            DropTable("dbo.Curso");
            DropTable("dbo.Turma");
            DropTable("dbo.AnoSem");
            DropTable("dbo.AnoLectivo");
            CreateIndex("dbo.Unidensinol", "Unidensinostamp");
            CreateIndex("dbo.Turhl", "Turhstamp");
            CreateIndex("dbo.Discl", "Discstamp");
            CreateIndex("dbo.Cursemdisc", "Cursemstamp");
            CreateIndex("dbo.Cursem", "Cursconfig_Cursconfigstamp");
            AddForeignKey("dbo.Unidensinol", "Unidensinostamp", "dbo.Unidensino", "Unidensinostamp", cascadeDelete: true);
            AddForeignKey("dbo.Turhl", "Turhstamp", "dbo.Turh", "Turhstamp", cascadeDelete: true);
            AddForeignKey("dbo.Discl", "Discstamp", "dbo.Disc", "Discstamp", cascadeDelete: true);
            AddForeignKey("dbo.Cursemdisc", "Cursemstamp", "dbo.Cursem", "Cursemstamp", cascadeDelete: true);
            AddForeignKey("dbo.Cursem", "Cursconfig_Cursconfigstamp", "dbo.Cursconfig", "Cursconfigstamp");
        }
    }
}
