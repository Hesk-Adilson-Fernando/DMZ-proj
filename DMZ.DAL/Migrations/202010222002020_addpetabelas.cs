namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpetabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Desconto",
                c => new
                    {
                        Descontostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descfixo = c.Boolean(nullable: false),
                        Decimo13 = c.Boolean(nullable: false),
                        Retro = c.Boolean(nullable: false),
                        Tipodesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vta = c.Boolean(nullable: false),
                        Insid = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Rectro = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Descontostamp);
            
            CreateTable(
                "dbo.Meses",
                c => new
                    {
                        Mesesstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.String(nullable: false, maxLength: 80),
                        Codtipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Mesesstamp);
            
            CreateTable(
                "dbo.Peemp",
                c => new
                    {
                        Peempstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Mesin = c.String(nullable: false, maxLength: 80),
                        Numprest = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Devsal = c.Boolean(nullable: false),
                        Devolvido = c.Boolean(nullable: false),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 250),
                        Codmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Banco = c.String(nullable: false, maxLength: 80),
                        Contatesoura = c.String(nullable: false, maxLength: 80),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Numtitulo = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Peempstamp);
            
            CreateTable(
                "dbo.Peempl",
                c => new
                    {
                        Peemplstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mespagar = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nummes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Pago = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ultdevol = c.DateTime(nullable: false),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Devolvido = c.Boolean(nullable: false),
                        Peempstamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Banco = c.String(nullable: false, maxLength: 80),
                        Contatesoura = c.String(nullable: false, maxLength: 80),
                        Titulo = c.String(nullable: false, maxLength: 80),
                        Numtitulo = c.String(nullable: false, maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Peemplstamp)
                .ForeignKey("dbo.Peemp", t => t.Peempstamp, cascadeDelete: true)
                .Index(t => t.Peempstamp);
            
            CreateTable(
                "dbo.Peempcc",
                c => new
                    {
                        Peempccstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nummes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Vencim = c.DateTime(nullable: false),
                        Debito = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Debitom = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Debitof = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Debitofm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Credito = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Creditom = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Creditof = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Creditofm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Peemplstamp = c.String(nullable: false, maxLength: 80),
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                        Origem = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(nullable: false, maxLength: 80),
                        Documento = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Codmov = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Empdevstamp = c.String(nullable: false, maxLength: 80),
                        Prcempstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Peempccstamp)
                .ForeignKey("dbo.Peempl", t => t.Peemplstamp, cascadeDelete: true)
                .Index(t => t.Peemplstamp);
            
            CreateTable(
                "dbo.Prcemp",
                c => new
                    {
                        Prcempstamp = c.String(nullable: false, maxLength: 30),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Peemplstamp = c.String(nullable: false, maxLength: 80),
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Prcempstamp)
                .ForeignKey("dbo.Peempl", t => t.Peemplstamp, cascadeDelete: true)
                .Index(t => t.Peemplstamp);
            
            CreateTable(
                "dbo.PeForm",
                c => new
                    {
                        Peformstamp = c.String(nullable: false, maxLength: 30),
                        Curso = c.String(nullable: false, maxLength: 80),
                        Tipo = c.String(nullable: false, maxLength: 80),
                        Instituicao = c.String(nullable: false, maxLength: 80),
                        Nivel = c.String(nullable: false, maxLength: 80),
                        Codnivel = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DataIn = c.DateTime(nullable: false),
                        Datafim = c.DateTime(nullable: false),
                        Duracao = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Codpais = c.String(nullable: false, maxLength: 80),
                        Pais = c.String(nullable: false, maxLength: 80),
                        Anofreq = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Peformstamp);
            
            CreateTable(
                "dbo.Prcextra",
                c => new
                    {
                        Prcextrastamp = c.String(nullable: false, maxLength: 30),
                        Processstamp = c.String(nullable: false, maxLength: 80),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Codcat = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cat = c.String(nullable: false, maxLength: 80),
                        Coddesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codfun = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Escalao = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Indice = c.String(nullable: false, maxLength: 80),
                        Codsec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codcl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Classe = c.String(nullable: false, maxLength: 80),
                        Quota = c.Boolean(nullable: false),
                        Sind = c.String(nullable: false, maxLength: 80),
                        Nsind = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codsit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Situacao = c.String(nullable: false, maxLength: 80),
                        Basecateg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totsub = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totabonus = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Liquido = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fechado = c.Boolean(nullable: false),
                        Extra = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Diferenca = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Prcextrastamp)
                .ForeignKey("dbo.Process", t => t.Processstamp, cascadeDelete: true)
                .Index(t => t.Processstamp);
            
            CreateTable(
                "dbo.Process",
                c => new
                    {
                        Processstamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Processado = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ultproc = c.DateTime(nullable: false),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Processstamp);
            
            CreateTable(
                "dbo.Profiss",
                c => new
                    {
                        Profissstamp = c.String(nullable: false, maxLength: 30),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Profissstamp);
            
            CreateTable(
                "dbo.Sub",
                c => new
                    {
                        Substamp = c.String(nullable: false, maxLength: 30),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tiposub = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Decimo13 = c.Boolean(nullable: false),
                        Rectro = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Substamp);
            
            AddColumn("dbo.Pe", "Motorista", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Docente", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "UsaValBasico", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Pecontra", "Codigo", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pesub", "Valor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Mescont", "Qmc");
            DropColumn("dbo.Mescont", "Qmcdathora");
            DropColumn("dbo.Mescont", "Qma");
            DropColumn("dbo.Mescont", "Qmadathora");
            DropColumn("dbo.Pefalta", "Hora");
            DropColumn("dbo.Pehextra", "Ano");
            DropColumn("dbo.Pehextra", "Nrmes");
            DropColumn("dbo.Pehextra", "Mes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pehextra", "Mes", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pehextra", "Nrmes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pehextra", "Ano", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Hora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mescont", "Qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mescont", "Qma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mescont", "Qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Mescont", "Qmc", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Prcextra", "Processstamp", "dbo.Process");
            DropForeignKey("dbo.Prcemp", "Peemplstamp", "dbo.Peempl");
            DropForeignKey("dbo.Peempcc", "Peemplstamp", "dbo.Peempl");
            DropForeignKey("dbo.Peempl", "Peempstamp", "dbo.Peemp");
            DropIndex("dbo.Prcextra", new[] { "Processstamp" });
            DropIndex("dbo.Prcemp", new[] { "Peemplstamp" });
            DropIndex("dbo.Peempcc", new[] { "Peemplstamp" });
            DropIndex("dbo.Peempl", new[] { "Peempstamp" });
            AlterColumn("dbo.Pesub", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pecontra", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pe", "UsaValBasico");
            DropColumn("dbo.Pe", "Docente");
            DropColumn("dbo.Pe", "Motorista");
            DropTable("dbo.Sub");
            DropTable("dbo.Profiss");
            DropTable("dbo.Process");
            DropTable("dbo.Prcextra");
            DropTable("dbo.PeForm");
            DropTable("dbo.Prcemp");
            DropTable("dbo.Peempcc");
            DropTable("dbo.Peempl");
            DropTable("dbo.Peemp");
            DropTable("dbo.Meses");
            DropTable("dbo.Desconto");
        }
    }
}
