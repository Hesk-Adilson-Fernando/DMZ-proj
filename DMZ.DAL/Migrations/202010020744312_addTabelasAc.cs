namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTabelasAc : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClTurma", newName: "ClTur");
            DropForeignKey("dbo.Peferias", "Pestamp", "dbo.Pe");
            DropIndex("dbo.Peferias", new[] { "Pestamp" });
            DropPrimaryKey("dbo.ClTur");
            CreateTable(
                "dbo.ClCur",
                c => new
                    {
                        ClCurstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Curso = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Fim = c.DateTime(nullable: false),
                        Concluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClCurstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            CreateTable(
                "dbo.ClCursem",
                c => new
                    {
                        Clcursemstamp = c.String(nullable: false, maxLength: 80),
                        ClCursostamp = c.String(nullable: false, maxLength: 80),
                        Codsem = c.String(nullable: false, maxLength: 80),
                        Sem = c.String(nullable: false, maxLength: 80),
                        ClCurso_ClCurstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Clcursemstamp)
                .ForeignKey("dbo.ClCur", t => t.ClCurso_ClCurstamp)
                .Index(t => t.ClCurso_ClCurstamp);
            
            CreateTable(
                "dbo.ClCursemdisc",
                c => new
                    {
                        ClCursemdiscstamp = c.String(nullable: false, maxLength: 80),
                        Coddisc = c.String(nullable: false, maxLength: 80),
                        Disc = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cargah = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prec = c.Boolean(nullable: false),
                        ClCursem_Clcursemstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.ClCursemdiscstamp)
                .ForeignKey("dbo.ClCursem", t => t.ClCursem_Clcursemstamp)
                .Index(t => t.ClCursem_Clcursemstamp);
            
            CreateTable(
                "dbo.ClDoc",
                c => new
                    {
                        Cldocstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Documento = c.String(nullable: false, maxLength: 80),
                        Numero = c.String(nullable: false, maxLength: 80),
                        Localemis = c.String(nullable: false, maxLength: 80),
                        Emissao = c.DateTime(nullable: false),
                        Validade = c.DateTime(nullable: false),
                        Bi = c.Boolean(nullable: false),
                        Imagem = c.Binary(),
                    })
                .PrimaryKey(t => t.Cldocstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            CreateTable(
                "dbo.ClDoenca",
                c => new
                    {
                        ClDoencastamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Doenca = c.String(nullable: false, maxLength: 80),
                        Coddoenca = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Fim = c.DateTime(nullable: false),
                        Cronica = c.Boolean(nullable: false),
                        Tratamento = c.String(nullable: false, maxLength: 650),
                    })
                .PrimaryKey(t => t.ClDoencastamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
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
                "dbo.Cursem",
                c => new
                    {
                        Cursemstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Cursoconfigstamp = c.String(nullable: false, maxLength: 80),
                        Cursconfig_Cursconfigstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Cursemstamp)
                .ForeignKey("dbo.Cursconfig", t => t.Cursconfig_Cursconfigstamp)
                .Index(t => t.Cursconfig_Cursconfigstamp);
            
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
                .PrimaryKey(t => t.Cursemdiscstamp)
                .ForeignKey("dbo.Cursem", t => t.Cursemstamp, cascadeDelete: true)
                .Index(t => t.Cursemstamp);
            
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
                "dbo.Discl",
                c => new
                    {
                        Disclstamp = c.String(nullable: false, maxLength: 80),
                        Discstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Disclstamp)
                .ForeignKey("dbo.Disc", t => t.Discstamp, cascadeDelete: true)
                .Index(t => t.Discstamp);
            
            CreateTable(
                "dbo.Inst",
                c => new
                    {
                        Inststamp = c.String(nullable: false, maxLength: 80),
                        Codesc = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 600),
                    })
                .PrimaryKey(t => t.Inststamp);
            
            CreateTable(
                "dbo.Instunid",
                c => new
                    {
                        Instunidstamp = c.String(nullable: false, maxLength: 80),
                        Inststamp = c.String(nullable: false, maxLength: 80),
                        Codesc = c.String(nullable: false, maxLength: 80),
                        Codunid = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 600),
                    })
                .PrimaryKey(t => t.Instunidstamp)
                .ForeignKey("dbo.Inst", t => t.Inststamp, cascadeDelete: true)
                .Index(t => t.Inststamp);
            
            CreateTable(
                "dbo.Instunidl",
                c => new
                    {
                        Instunidlstamp = c.String(nullable: false, maxLength: 80),
                        Instunidstamp = c.String(nullable: false, maxLength: 80),
                        Coduni = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 600),
                    })
                .PrimaryKey(t => t.Instunidlstamp)
                .ForeignKey("dbo.Instunid", t => t.Instunidstamp, cascadeDelete: true)
                .Index(t => t.Instunidstamp);
            
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
            
            CreateTable(
                "dbo.Mat",
                c => new
                    {
                        Matriculastamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Numero = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Curso = c.String(nullable: false, maxLength: 80),
                        Codcurso = c.String(nullable: false, maxLength: 80),
                        Datamat = c.DateTime(nullable: false),
                        Turno = c.String(nullable: false, maxLength: 80),
                        Periodo = c.String(nullable: false, maxLength: 80),
                        Turma = c.String(nullable: false, maxLength: 80),
                        Codtur = c.String(nullable: false, maxLength: 80),
                        Anolect = c.String(nullable: false, maxLength: 80),
                        Localmat = c.String(nullable: false, maxLength: 80),
                        Emails = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.Matriculastamp);
            
            CreateTable(
                "dbo.Matdisc",
                c => new
                    {
                        Matdiscstamp = c.String(nullable: false, maxLength: 80),
                        Matstamp = c.String(nullable: false, maxLength: 80),
                        Coddisc = c.String(nullable: false, maxLength: 80),
                        Disc = c.String(nullable: false, maxLength: 80),
                        Mat_Matriculastamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Matdiscstamp)
                .ForeignKey("dbo.Mat", t => t.Mat_Matriculastamp)
                .Index(t => t.Mat_Matriculastamp);
            
            CreateTable(
                "dbo.Pebanc",
                c => new
                    {
                        Pebancstamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Conta = c.Long(nullable: false),
                        Nib = c.String(nullable: false, maxLength: 80),
                        Swift = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pebancstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pecont",
                c => new
                    {
                        Pecontstamp = c.String(nullable: false, maxLength: 80),
                        NrTelefEmail = c.String(nullable: false, maxLength: 80),
                        Email = c.Boolean(nullable: false),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pecontstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pedoc",
                c => new
                    {
                        Pedocstamp = c.String(nullable: false, maxLength: 80),
                        Documento = c.String(nullable: false, maxLength: 80),
                        Numero = c.String(nullable: false, maxLength: 80),
                        Local = c.String(nullable: false, maxLength: 80),
                        Emissao = c.DateTime(nullable: false),
                        Validade = c.DateTime(nullable: false),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Bi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Pedocstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pefam",
                c => new
                    {
                        Pefamstamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Grau = c.String(nullable: false, maxLength: 80),
                        DataNasc = c.DateTime(nullable: false),
                        Prov = c.String(nullable: false, maxLength: 80),
                        Dist = c.String(nullable: false, maxLength: 80),
                        Pad = c.String(nullable: false, maxLength: 80),
                        Morada = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pefamstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pefer",
                c => new
                    {
                        Peferstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estado = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Peferstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Peling",
                c => new
                    {
                        Pelingstamp = c.String(nullable: false, maxLength: 80),
                        Lingua = c.String(nullable: false, maxLength: 80),
                        Fala = c.String(nullable: false, maxLength: 80),
                        Leitura = c.String(nullable: false, maxLength: 80),
                        Escrita = c.String(nullable: false, maxLength: 80),
                        Compreecao = c.String(nullable: false, maxLength: 80),
                        Materna = c.Boolean(nullable: false),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pelingstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pesind",
                c => new
                    {
                        Pesindstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Numero = c.String(nullable: false, maxLength: 80),
                        Perc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 500),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pesindstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Pesit",
                c => new
                    {
                        Pesitstamp = c.String(nullable: false, maxLength: 80),
                        TipoInfracao = c.String(nullable: false, maxLength: 80),
                        NrProcesso = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.String(nullable: false, maxLength: 80),
                        Pena = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pesitstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Peaux",
                c => new
                    {
                        Peauxstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tabela = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desctabela = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Peauxstamp);
            
            CreateTable(
                "dbo.Peri",
                c => new
                    {
                        Peristamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Fim = c.DateTime(nullable: false),
                        Concluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Peristamp);
            
            CreateTable(
                "dbo.Pericur",
                c => new
                    {
                        Pericurstamp = c.String(nullable: false, maxLength: 80),
                        Peristamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Nivel = c.String(nullable: false, maxLength: 80),
                        Tipo = c.String(nullable: false, maxLength: 80),
                        Status = c.String(nullable: false, maxLength: 80),
                        Descperiodo = c.String(nullable: false, maxLength: 80),
                        Anolect = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pericurstamp)
                .ForeignKey("dbo.Peri", t => t.Peristamp, cascadeDelete: true)
                .Index(t => t.Peristamp);
            
            CreateTable(
                "dbo.Pericursem",
                c => new
                    {
                        Pericursemstamp = c.String(nullable: false, maxLength: 80),
                        Pericurstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.Pericursemstamp)
                .ForeignKey("dbo.Pericur", t => t.Pericurstamp, cascadeDelete: true)
                .Index(t => t.Pericurstamp);
            
            CreateTable(
                "dbo.Pericursemtur",
                c => new
                    {
                        Pericursemturstamp = c.String(nullable: false, maxLength: 80),
                        Pericursemstamp = c.String(nullable: false, maxLength: 80),
                        Pericurstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Turclasse = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 400),
                        Sala = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Pericursemturstamp)
                .ForeignKey("dbo.Pericursem", t => t.Pericursemstamp, cascadeDelete: true)
                .Index(t => t.Pericursemstamp);
            
            CreateTable(
                "dbo.Petur",
                c => new
                    {
                        Peturstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Codturma = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Semestre = c.String(nullable: false, maxLength: 80),
                        Disciplina = c.String(nullable: false, maxLength: 80),
                        Anolect = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Peturstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            CreateTable(
                "dbo.Transp",
                c => new
                    {
                        Transpstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Morada = c.String(nullable: false, maxLength: 80),
                        Celular = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Transpstamp);
            
            CreateTable(
                "dbo.Transpvt",
                c => new
                    {
                        Transpvtstamp = c.String(nullable: false, maxLength: 80),
                        Transpstamp = c.String(nullable: false, maxLength: 80),
                        Marca = c.String(nullable: false, maxLength: 80),
                        Modelo = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Motorista = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Transpvtstamp)
                .ForeignKey("dbo.Transp", t => t.Transpstamp, cascadeDelete: true)
                .Index(t => t.Transpstamp);
            
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
                .PrimaryKey(t => t.Turhlstamp)
                .ForeignKey("dbo.Turh", t => t.Turhstamp, cascadeDelete: true)
                .Index(t => t.Turhstamp);
            
            AddColumn("dbo.Cl", "Aluno", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Estadocivil", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Religiao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Nivelac", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Codaluno", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Codesc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Escola", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Planosaude", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Medico", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Hospital", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Instplanosaude", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Transp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Sozinho", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Acompanhado", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClContact", "Pai", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClContact", "Mae", c => c.Boolean(nullable: false));
            AddColumn("dbo.ClContact", "Profissao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClContact", "Retiraluno", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "RegimeCasamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "DataCasamento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "ProvNasc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "DistNasc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "PadNasc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Bairro", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "ProvMorada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "DistMorada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "PadMorada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodNivelAcademico", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "NivelAcademico", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodCateg", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescricaoCateg", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodProfissao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescProfissao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodDepart", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescDepart", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodRepart", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescRepart", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodSeccao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "DescSeccao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "PercentagemIrps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "InscritoInss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "NrSegurancaSocial", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "RelPonto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "NomeRelPonto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "UtilValBasico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "ValBasico", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "NrDepend", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "ObservacaoPe", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pedesc", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "Hora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pefalta", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "Justificada", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "Obs", c => c.String(nullable: false, maxLength: 500));
            AddColumn("dbo.Pesub", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Mudasenha", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Codgrupo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Usr", "Grupo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Status", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Codstatus", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Imagem", c => c.Binary());
            AddColumn("dbo.Usr", "Oristamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "ClTurstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Codtur", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Codcurso", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Curso", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Anolect", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Matricula", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Datamat", c => c.DateTime(nullable: false));
            AddColumn("dbo.ClTur", "Turno", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Periodo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Localmat", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Cl", "Obs", c => c.String(nullable: false, maxLength: 650));
            AddPrimaryKey("dbo.ClTur", "ClTurstamp");
            DropColumn("dbo.Cl", "CodInst");
            DropColumn("dbo.Cl", "Instbolsa");
            DropColumn("dbo.Cl", "Tipobolsa");
            DropColumn("dbo.Cl", "Codsem");
            DropColumn("dbo.Cl", "Semestre");
            DropColumn("dbo.Pe", "Morada");
            DropColumn("dbo.Pe", "Locali");
            DropColumn("dbo.Pe", "Natural");
            DropColumn("dbo.Pe", "Contacto");
            DropColumn("dbo.Pe", "Email");
            DropColumn("dbo.Pe", "Codstatus");
            DropColumn("dbo.Pe", "Descstatus");
            DropColumn("dbo.Pe", "Codcat");
            DropColumn("dbo.Pe", "Desccat");
            DropColumn("dbo.Pe", "Codprof");
            DropColumn("dbo.Pe", "Descprof");
            DropColumn("dbo.Pe", "Dataadm");
            DropColumn("dbo.Pe", "Tipodocum");
            DropColumn("dbo.Pe", "Numdocum");
            DropColumn("dbo.Pe", "Locemiss");
            DropColumn("dbo.Pe", "Dataemiss");
            DropColumn("dbo.Pe", "Documvalid");
            DropColumn("dbo.Pe", "Codhabliter");
            DropColumn("dbo.Pe", "Habliter");
            DropColumn("dbo.Pe", "Codbanco");
            DropColumn("dbo.Pe", "Banco");
            DropColumn("dbo.Pe", "Numconta");
            DropColumn("dbo.Pe", "Nib");
            DropColumn("dbo.Pe", "Trf");
            DropColumn("dbo.Pe", "Ntabelado");
            DropColumn("dbo.Pe", "Ponto");
            DropColumn("dbo.Pe", "Pontonome");
            DropColumn("dbo.Pe", "Valbase");
            DropColumn("dbo.Pe", "Nrdep");
            DropColumn("dbo.Pe", "Codsgs");
            DropColumn("dbo.Pe", "Descsgs");
            DropColumn("dbo.Pe", "Numsgs");
            DropColumn("dbo.Pe", "Codtiposgs");
            DropColumn("dbo.Pe", "Desctiposgs");
            DropColumn("dbo.Pe", "Numsindic");
            DropColumn("dbo.Pe", "Codsindic");
            DropColumn("dbo.Pe", "Descsindic");
            DropColumn("dbo.Pe", "Persindic");
            DropColumn("dbo.Pe", "Codlevel1");
            DropColumn("dbo.Pe", "Desclevel1");
            DropColumn("dbo.Pe", "Codlevel2");
            DropColumn("dbo.Pe", "Desclevel2");
            DropColumn("dbo.Pe", "Codlevel3");
            DropColumn("dbo.Pe", "Desclevel3");
            DropColumn("dbo.Pe", "Codlevel4");
            DropColumn("dbo.Pe", "Desclevel4");
            DropColumn("dbo.Pe", "Codccusto");
            DropColumn("dbo.Pe", "Desccusto");
            DropColumn("dbo.Pe", "Obs");
            DropColumn("dbo.Pedesc", "Status");
            DropColumn("dbo.Pefalta", "Origem");
            DropColumn("dbo.Pefalta", "Fjust");
            DropColumn("dbo.Pefalta", "Finjust");
            DropColumn("dbo.Pefalta", "Total");
            DropColumn("dbo.Pefalta", "Desctfalta");
            DropColumn("dbo.Pefalta", "Codtfalta");
            DropColumn("dbo.Pefalta", "Ano");
            DropColumn("dbo.Pefalta", "Nrmes");
            DropColumn("dbo.Pefalta", "Mes");
            DropColumn("dbo.Pesub", "Status");
            DropColumn("dbo.Usr", "Activo");
            DropColumn("dbo.Usr", "SomentePos");
            DropColumn("dbo.ClTur", "ClTurmastamp");
            DropColumn("dbo.ClTur", "Classe");
            DropColumn("dbo.ClTur", "Ano");
            DropColumn("dbo.ClTur", "Data");
            DropColumn("dbo.ClTur", "Docente");
            DropColumn("dbo.ClTur", "Coddoc");
            DropTable("dbo.Peferias");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Peferias",
                c => new
                    {
                        Peferiasstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estado = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Peferiasstamp);
            
            AddColumn("dbo.ClTur", "Coddoc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.ClTur", "Docente", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "Data", c => c.DateTime(nullable: false));
            AddColumn("dbo.ClTur", "Ano", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.ClTur", "Classe", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClTur", "ClTurmastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "SomentePos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pesub", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "Mes", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "Nrmes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Ano", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Codtfalta", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Desctfalta", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "Total", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Finjust", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Fjust", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Origem", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pedesc", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Obs", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Desccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Desclevel4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codlevel4", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Desclevel3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codlevel3", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Desclevel2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codlevel2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Desclevel1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codlevel1", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Persindic", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Descsindic", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codsindic", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Numsindic", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Desctiposgs", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codtiposgs", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Numsgs", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Descsgs", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codsgs", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Nrdep", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Valbase", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Pontonome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Ponto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Ntabelado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Trf", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Nib", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Numconta", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Banco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codbanco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Habliter", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codhabliter", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Documvalid", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "Dataemiss", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "Locemiss", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Numdocum", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Tipodocum", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Dataadm", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "Descprof", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codprof", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Desccat", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codcat", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Descstatus", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codstatus", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Email", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Contacto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Natural", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Locali", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Semestre", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Codsem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Tipobolsa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Instbolsa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "CodInst", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Turhl", "Turhstamp", "dbo.Turh");
            DropForeignKey("dbo.Transpvt", "Transpstamp", "dbo.Transp");
            DropForeignKey("dbo.Petur", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pericursemtur", "Pericursemstamp", "dbo.Pericursem");
            DropForeignKey("dbo.Pericursem", "Pericurstamp", "dbo.Pericur");
            DropForeignKey("dbo.Pericur", "Peristamp", "dbo.Peri");
            DropForeignKey("dbo.Pesit", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pesind", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Peling", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pefer", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pefam", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pedoc", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pecont", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Pebanc", "Pestamp", "dbo.Pe");
            DropForeignKey("dbo.Matdisc", "Mat_Matriculastamp", "dbo.Mat");
            DropForeignKey("dbo.Instunidl", "Instunidstamp", "dbo.Instunid");
            DropForeignKey("dbo.Instunid", "Inststamp", "dbo.Inst");
            DropForeignKey("dbo.Discl", "Discstamp", "dbo.Disc");
            DropForeignKey("dbo.Cursemdisc", "Cursemstamp", "dbo.Cursem");
            DropForeignKey("dbo.Cursem", "Cursconfig_Cursconfigstamp", "dbo.Cursconfig");
            DropForeignKey("dbo.ClDoenca", "Clstamp", "dbo.Cl");
            DropForeignKey("dbo.ClDoc", "Clstamp", "dbo.Cl");
            DropForeignKey("dbo.ClCursem", "ClCurso_ClCurstamp", "dbo.ClCur");
            DropForeignKey("dbo.ClCursemdisc", "ClCursem_Clcursemstamp", "dbo.ClCursem");
            DropForeignKey("dbo.ClCur", "Clstamp", "dbo.Cl");
            DropIndex("dbo.Turhl", new[] { "Turhstamp" });
            DropIndex("dbo.Transpvt", new[] { "Transpstamp" });
            DropIndex("dbo.Petur", new[] { "Pestamp" });
            DropIndex("dbo.Pericursemtur", new[] { "Pericursemstamp" });
            DropIndex("dbo.Pericursem", new[] { "Pericurstamp" });
            DropIndex("dbo.Pericur", new[] { "Peristamp" });
            DropIndex("dbo.Pesit", new[] { "Pestamp" });
            DropIndex("dbo.Pesind", new[] { "Pestamp" });
            DropIndex("dbo.Peling", new[] { "Pestamp" });
            DropIndex("dbo.Pefer", new[] { "Pestamp" });
            DropIndex("dbo.Pefam", new[] { "Pestamp" });
            DropIndex("dbo.Pedoc", new[] { "Pestamp" });
            DropIndex("dbo.Pecont", new[] { "Pestamp" });
            DropIndex("dbo.Pebanc", new[] { "Pestamp" });
            DropIndex("dbo.Matdisc", new[] { "Mat_Matriculastamp" });
            DropIndex("dbo.Instunidl", new[] { "Instunidstamp" });
            DropIndex("dbo.Instunid", new[] { "Inststamp" });
            DropIndex("dbo.Discl", new[] { "Discstamp" });
            DropIndex("dbo.Cursemdisc", new[] { "Cursemstamp" });
            DropIndex("dbo.Cursem", new[] { "Cursconfig_Cursconfigstamp" });
            DropIndex("dbo.ClDoenca", new[] { "Clstamp" });
            DropIndex("dbo.ClDoc", new[] { "Clstamp" });
            DropIndex("dbo.ClCursemdisc", new[] { "ClCursem_Clcursemstamp" });
            DropIndex("dbo.ClCursem", new[] { "ClCurso_ClCurstamp" });
            DropIndex("dbo.ClCur", new[] { "Clstamp" });
            DropPrimaryKey("dbo.ClTur");
            AlterColumn("dbo.Cl", "Obs", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.ClTur", "Localmat");
            DropColumn("dbo.ClTur", "Periodo");
            DropColumn("dbo.ClTur", "Turno");
            DropColumn("dbo.ClTur", "Datamat");
            DropColumn("dbo.ClTur", "Matricula");
            DropColumn("dbo.ClTur", "Anolect");
            DropColumn("dbo.ClTur", "Curso");
            DropColumn("dbo.ClTur", "Codcurso");
            DropColumn("dbo.ClTur", "Codtur");
            DropColumn("dbo.ClTur", "ClTurstamp");
            DropColumn("dbo.Usr", "Oristamp");
            DropColumn("dbo.Usr", "Imagem");
            DropColumn("dbo.Usr", "Codstatus");
            DropColumn("dbo.Usr", "Status");
            DropColumn("dbo.Usr", "Grupo");
            DropColumn("dbo.Usr", "Codgrupo");
            DropColumn("dbo.Usr", "Mudasenha");
            DropColumn("dbo.Pesub", "Estado");
            DropColumn("dbo.Pefalta", "Obs");
            DropColumn("dbo.Pefalta", "Justificada");
            DropColumn("dbo.Pefalta", "Descricao");
            DropColumn("dbo.Pefalta", "Hora");
            DropColumn("dbo.Pedesc", "Estado");
            DropColumn("dbo.Pe", "ObservacaoPe");
            DropColumn("dbo.Pe", "NrDepend");
            DropColumn("dbo.Pe", "ValBasico");
            DropColumn("dbo.Pe", "UtilValBasico");
            DropColumn("dbo.Pe", "NomeRelPonto");
            DropColumn("dbo.Pe", "RelPonto");
            DropColumn("dbo.Pe", "NrSegurancaSocial");
            DropColumn("dbo.Pe", "InscritoInss");
            DropColumn("dbo.Pe", "PercentagemIrps");
            DropColumn("dbo.Pe", "DescSeccao");
            DropColumn("dbo.Pe", "CodSeccao");
            DropColumn("dbo.Pe", "DescRepart");
            DropColumn("dbo.Pe", "CodRepart");
            DropColumn("dbo.Pe", "DescDepart");
            DropColumn("dbo.Pe", "CodDepart");
            DropColumn("dbo.Pe", "DescProfissao");
            DropColumn("dbo.Pe", "CodProfissao");
            DropColumn("dbo.Pe", "DescricaoCateg");
            DropColumn("dbo.Pe", "CodCateg");
            DropColumn("dbo.Pe", "NivelAcademico");
            DropColumn("dbo.Pe", "CodNivelAcademico");
            DropColumn("dbo.Pe", "PadMorada");
            DropColumn("dbo.Pe", "DistMorada");
            DropColumn("dbo.Pe", "ProvMorada");
            DropColumn("dbo.Pe", "Bairro");
            DropColumn("dbo.Pe", "PadNasc");
            DropColumn("dbo.Pe", "DistNasc");
            DropColumn("dbo.Pe", "ProvNasc");
            DropColumn("dbo.Pe", "DataCasamento");
            DropColumn("dbo.Pe", "RegimeCasamento");
            DropColumn("dbo.ClContact", "Retiraluno");
            DropColumn("dbo.ClContact", "Profissao");
            DropColumn("dbo.ClContact", "Mae");
            DropColumn("dbo.ClContact", "Pai");
            DropColumn("dbo.Cl", "Acompanhado");
            DropColumn("dbo.Cl", "Sozinho");
            DropColumn("dbo.Cl", "Transp");
            DropColumn("dbo.Cl", "Instplanosaude");
            DropColumn("dbo.Cl", "Hospital");
            DropColumn("dbo.Cl", "Medico");
            DropColumn("dbo.Cl", "Planosaude");
            DropColumn("dbo.Cl", "Escola");
            DropColumn("dbo.Cl", "Codesc");
            DropColumn("dbo.Cl", "Codaluno");
            DropColumn("dbo.Cl", "Nivelac");
            DropColumn("dbo.Cl", "Religiao");
            DropColumn("dbo.Cl", "Estadocivil");
            DropColumn("dbo.Cl", "Aluno");
            DropTable("dbo.Turhl");
            DropTable("dbo.Turh");
            DropTable("dbo.Transpvt");
            DropTable("dbo.Transp");
            DropTable("dbo.Petur");
            DropTable("dbo.Pericursemtur");
            DropTable("dbo.Pericursem");
            DropTable("dbo.Pericur");
            DropTable("dbo.Peri");
            DropTable("dbo.Peaux");
            DropTable("dbo.Pesit");
            DropTable("dbo.Pesind");
            DropTable("dbo.Peling");
            DropTable("dbo.Pefer");
            DropTable("dbo.Pefam");
            DropTable("dbo.Pedoc");
            DropTable("dbo.Pecont");
            DropTable("dbo.Pebanc");
            DropTable("dbo.Matdisc");
            DropTable("dbo.Mat");
            DropTable("dbo.Lnota");
            DropTable("dbo.Instunidl");
            DropTable("dbo.Instunid");
            DropTable("dbo.Inst");
            DropTable("dbo.Discl");
            DropTable("dbo.Disc");
            DropTable("dbo.Cursemdisc");
            DropTable("dbo.Cursem");
            DropTable("dbo.Cursconfig");
            DropTable("dbo.ClDoenca");
            DropTable("dbo.ClDoc");
            DropTable("dbo.ClCursemdisc");
            DropTable("dbo.ClCursem");
            DropTable("dbo.ClCur");
            AddPrimaryKey("dbo.ClTur", "ClTurmastamp");
            CreateIndex("dbo.Peferias", "Pestamp");
            AddForeignKey("dbo.Peferias", "Pestamp", "dbo.Pe", "Pestamp", cascadeDelete: true);
            RenameTable(name: "dbo.ClTur", newName: "ClTurma");
        }
    }
}
