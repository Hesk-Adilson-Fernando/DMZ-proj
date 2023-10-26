namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrcTabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FncProc",
                c => new
                    {
                        FncProcstamp = c.String(nullable: false, maxLength: 80),
                        Fncstamp = c.String(nullable: false, maxLength: 80),
                        Avaliacao = c.String(nullable: false),
                        Criterio = c.String(nullable: false),
                        Grau = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FncProcstamp)
                .ForeignKey("dbo.Fnc", t => t.Fncstamp, cascadeDelete: true)
                .Index(t => t.Fncstamp);
            
            CreateTable(
                "dbo.ProcAnalFnc",
                c => new
                    {
                        ProcAnalFncstamp = c.String(nullable: false, maxLength: 80),
                        Procurmstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false),
                        Tipo = c.String(nullable: false),
                        Duracao = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Qual = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estado = c.String(nullable: false, maxLength: 80),
                        Sequenc = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(),
                        Termino = c.DateTime(),
                        PrazoEntrega = c.DateTime(),
                        Ref = c.String(nullable: false, maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Unidade = c.String(nullable: false, maxLength: 80),
                        Armazem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mpreco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Tabiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valival = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Perdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descontol = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Subtotall = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Oristampl = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(nullable: false, maxLength: 80),
                        Descarm = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Totall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Executado = c.Boolean(nullable: false),
                        Ivainc = c.Boolean(nullable: false),
                        Servico = c.Boolean(nullable: false),
                        Encerrado = c.Boolean(nullable: false),
                        Factura = c.Boolean(nullable: false),
                        Adenda = c.Boolean(nullable: false),
                        SubContrada = c.Boolean(nullable: false),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        PrecoCompra = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Perc = c.Decimal(nullable: false, precision: 9, scale: 2),
                    })
                .PrimaryKey(t => t.ProcAnalFncstamp)
                .ForeignKey("dbo.Procurm", t => t.Procurmstamp, cascadeDelete: true)
                .Index(t => t.Procurmstamp);
            
            CreateTable(
                "dbo.Procurm",
                c => new
                    {
                        Procurmstamp = c.String(nullable: false, maxLength: 80),
                        GaranProv = c.String(nullable: false),
                        NumLote = c.String(nullable: false),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Datini = c.DateTime(nullable: false),
                        Datfim = c.DateTime(nullable: false),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false),
                        Horaabert = c.DateTime(nullable: false),
                        Descricao = c.String(nullable: false),
                        Classe = c.String(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Datfecho = c.DateTime(nullable: false),
                        Tcusto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TRecebido = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TPago = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Orc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Adenda = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Adendaper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totorc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TotComp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totft = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TotGI = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totftper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totrec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totrecper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totprec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totprecper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totpft = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totpftper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lucro = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lucroper = c.Decimal(nullable: false, precision: 9, scale: 0),
                        LclProp = c.String(nullable: false),
                        Ugea = c.String(nullable: false),
                        Regime = c.String(nullable: false),
                        Modalidade = c.String(nullable: false),
                        Criter = c.String(nullable: false),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Codccu = c.String(nullable: false, maxLength: 80),
                        Ccudesc = c.String(nullable: false, maxLength: 80),
                        Status = c.String(nullable: false, maxLength: 80),
                        Totpessoal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totvt = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TotProc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totcusto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codprov = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prov = c.String(nullable: false, maxLength: 80),
                        Coddist = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dist = c.String(nullable: false, maxLength: 80),
                        Endereco = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Procurmstamp);
            
            CreateTable(
                "dbo.Procurml",
                c => new
                    {
                        Procurmlstamp = c.String(nullable: false, maxLength: 80),
                        Procurmstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false),
                        Tipo = c.String(nullable: false),
                        Duracao = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Qual = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estado = c.String(nullable: false, maxLength: 80),
                        Sequenc = c.String(nullable: false, maxLength: 80),
                        Inicio = c.DateTime(),
                        Termino = c.DateTime(),
                        PrazoEntrega = c.DateTime(),
                        Ref = c.String(nullable: false, maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Unidade = c.String(nullable: false, maxLength: 80),
                        Armazem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mpreco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Tabiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valival = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Perdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descontol = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Subtotall = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Oristampl = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(nullable: false, maxLength: 80),
                        Descarm = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false),
                        Totall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Executado = c.Boolean(nullable: false),
                        Ivainc = c.Boolean(nullable: false),
                        Servico = c.Boolean(nullable: false),
                        Encerrado = c.Boolean(nullable: false),
                        Factura = c.Boolean(nullable: false),
                        Adenda = c.Boolean(nullable: false),
                        SubContrada = c.Boolean(nullable: false),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        PrecoCompra = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Perc = c.Decimal(nullable: false, precision: 9, scale: 2),
                    })
                .PrimaryKey(t => t.Procurmlstamp)
                .ForeignKey("dbo.Procurm", t => t.Procurmstamp, cascadeDelete: true)
                .Index(t => t.Procurmstamp);
            
            CreateTable(
                "dbo.ProcCrt",
                c => new
                    {
                        ProcCrtstamp = c.String(nullable: false, maxLength: 80),
                        Procurmstamp = c.String(nullable: false, maxLength: 80),
                        Criterio = c.String(nullable: false),
                        Grau = c.String(nullable: false),
                        Avaliacao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProcCrtstamp)
                .ForeignKey("dbo.Procurm", t => t.Procurmstamp, cascadeDelete: true)
                .Index(t => t.Procurmstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProcCrt", "Procurmstamp", "dbo.Procurm");
            DropForeignKey("dbo.ProcAnalFnc", "Procurmstamp", "dbo.Procurm");
            DropForeignKey("dbo.Procurml", "Procurmstamp", "dbo.Procurm");
            DropForeignKey("dbo.FncProc", "Fncstamp", "dbo.Fnc");
            DropIndex("dbo.ProcCrt", new[] { "Procurmstamp" });
            DropIndex("dbo.Procurml", new[] { "Procurmstamp" });
            DropIndex("dbo.ProcAnalFnc", new[] { "Procurmstamp" });
            DropIndex("dbo.FncProc", new[] { "Fncstamp" });
            DropTable("dbo.ProcCrt");
            DropTable("dbo.Procurml");
            DropTable("dbo.Procurm");
            DropTable("dbo.ProcAnalFnc");
            DropTable("dbo.FncProc");
        }
    }
}
