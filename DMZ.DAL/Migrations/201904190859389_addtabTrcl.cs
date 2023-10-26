namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtabTrcl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Docmodulo",
                c => new
                    {
                        Docmodulostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Estado = c.Boolean(nullable: false),
                        Rltstamp = c.String(maxLength: 80),
                        Tdistamp = c.String(maxLength: 80),
                        Tdocstamp = c.String(maxLength: 80),
                        Trclstamp = c.String(maxLength: 80),
                        Trdstamp = c.String(maxLength: 80),
                        Tdocfstamp = c.String(maxLength: 80),
                        Tpgfstamp = c.String(maxLength: 80),
                        Trdfstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Docmodulostamp)
                .ForeignKey("dbo.Rlt", t => t.Rltstamp)
                .ForeignKey("dbo.Tdi", t => t.Tdistamp)
                .ForeignKey("dbo.Tdoc", t => t.Tdocstamp)
                .ForeignKey("dbo.Tdocf", t => t.Tdocfstamp)
                .ForeignKey("dbo.TRcl", t => t.Trclstamp)
                .ForeignKey("dbo.Trd", t => t.Trdstamp)
                .ForeignKey("dbo.Trdf", t => t.Trdfstamp)
                .Index(t => t.Rltstamp)
                .Index(t => t.Tdistamp)
                .Index(t => t.Tdocstamp)
                .Index(t => t.Trclstamp)
                .Index(t => t.Trdstamp)
                .Index(t => t.Tdocfstamp)
                .Index(t => t.Trdfstamp);
            
            CreateTable(
                "dbo.Rlt",
                c => new
                    {
                        Rltstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        qmc = c.String(maxLength: 80),
                        qmcdathora = c.DateTime(nullable: false),
                        qma = c.String(maxLength: 80),
                        qmadathora = c.DateTime(nullable: false),
                        Tipofilter = c.Decimal(nullable: false, precision: 9, scale: 0),
                        campotabela1 = c.Boolean(nullable: false),
                        Lista = c.Boolean(nullable: false),
                        usaca = c.Boolean(nullable: false),
                        ComboQry1 = c.String(maxLength: 80),
                        tmColunas = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tmGrid = c.String(maxLength: 80),
                        clnBold = c.String(maxLength: 80),
                        clmMask = c.String(maxLength: 80),
                        clnHeader = c.String(maxLength: 80),
                        clnAlign = c.String(maxLength: 80),
                        clnCor = c.String(maxLength: 80),
                        clnTab = c.String(maxLength: 80),
                        clnReport = c.Boolean(nullable: false),
                        crQuery = c.String(maxLength: 80),
                        menuint = c.Boolean(nullable: false),
                        filefrx = c.String(maxLength: 80),
                        filefrt = c.String(maxLength: 80),
                        painel = c.Boolean(nullable: false),
                        btncriadoc = c.Boolean(nullable: false),
                        btndestino = c.Boolean(nullable: false),
                        btnorigem = c.Boolean(nullable: false),
                        ecran = c.String(maxLength: 80),
                        tabela = c.String(maxLength: 80),
                        campotabela2 = c.Boolean(nullable: false),
                        ComboQry2 = c.String(maxLength: 80),
                        Titlocal2 = c.String(maxLength: 80),
                        campotabela3 = c.Boolean(nullable: false),
                        ComboQry3 = c.String(maxLength: 80),
                        Titlocal3 = c.String(maxLength: 80),
                        campotabela4 = c.Boolean(nullable: false),
                        ComboQry4 = c.String(maxLength: 80),
                        Titlocal4 = c.String(maxLength: 80),
                        campotabela5 = c.Boolean(nullable: false),
                        ComboQry5 = c.String(maxLength: 80),
                        Titlocal5 = c.String(maxLength: 80),
                        campotabela6 = c.Boolean(nullable: false),
                        ComboQry6 = c.String(maxLength: 80),
                        Titlocal6 = c.String(maxLength: 80),
                        campotabela7 = c.Boolean(nullable: false),
                        ComboQry7 = c.String(maxLength: 80),
                        Titlocal7 = c.String(maxLength: 80),
                        campotabela8 = c.Boolean(nullable: false),
                        ComboQry8 = c.String(maxLength: 80),
                        Titlocal8 = c.String(maxLength: 80),
                        campotabela9 = c.Boolean(nullable: false),
                        ComboQry9 = c.String(maxLength: 80),
                        Titlocal9 = c.String(maxLength: 80),
                        TipoRlt = c.Decimal(nullable: false, precision: 9, scale: 0),
                        rltGrafico = c.Boolean(nullable: false),
                        titlocal1 = c.String(maxLength: 80),
                        codcampo1 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo1 = c.String(maxLength: 80),
                        codcampo2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo2 = c.String(maxLength: 80),
                        codcampo3 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo3 = c.String(maxLength: 80),
                        codcampo4 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo4 = c.String(maxLength: 80),
                        codcampo5 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo5 = c.String(maxLength: 80),
                        codcampo6 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo6 = c.String(maxLength: 80),
                        codcampo7 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo7 = c.String(maxLength: 80),
                        codcampo8 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo8 = c.String(maxLength: 80),
                        codcampo9 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mascampo9 = c.String(maxLength: 80),
                        filtros = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Rltstamp);
            
            CreateTable(
                "dbo.TRcl",
                c => new
                    {
                        TRclstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Descmovcc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contastesoura = c.String(maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Titulo = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Entida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        activo = c.Boolean(nullable: false),
                        Defa = c.Boolean(nullable: false),
                        Qmc = c.String(maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                        Alteranum = c.Boolean(nullable: false),
                        Usaemail = c.Boolean(nullable: false),
                        Usaanexo = c.Boolean(nullable: false),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(maxLength: 80),
                        TesouraPgc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Etpemiss = c.Boolean(nullable: false),
                        Etpimpress = c.Boolean(nullable: false),
                        Etpemail = c.Boolean(nullable: false),
                        Etpemisstxt = c.String(maxLength: 80),
                        Etpimpresstxt = c.String(maxLength: 80),
                        Etpemailtxt = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.TRclstamp);
            
            CreateTable(
                "dbo.Trd",
                c => new
                    {
                        Trdstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Descmovcc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contastesoura = c.String(maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Titulo = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Entida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Activo = c.Boolean(nullable: false),
                        Defa = c.Boolean(nullable: false),
                        qmc = c.String(maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        qma = c.String(maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                        Usaanexo = c.Boolean(nullable: false),
                        Usaemail = c.Boolean(nullable: false),
                        TesouraPgc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(maxLength: 80),
                        Etpemiss = c.Boolean(nullable: false),
                        Etpimpress = c.Boolean(nullable: false),
                        Etpemail = c.Boolean(nullable: false),
                        Etpemisstxt = c.String(maxLength: 80),
                        Etpimpresstxt = c.String(maxLength: 80),
                        Etpemailtxt = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Trdstamp);
            
            CreateTable(
                "dbo.Trdf",
                c => new
                    {
                        Trdfstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Descmovcc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contastesoura = c.String(maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Titulo = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Entida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Activo = c.Boolean(nullable: false),
                        Defa = c.Boolean(nullable: false),
                        Qmc = c.String(maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                        Usaanexo = c.Boolean(nullable: false),
                        Usaemail = c.Boolean(nullable: false),
                        TesouraPgc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Etpemiss = c.Boolean(nullable: false),
                        Etpimpress = c.Boolean(nullable: false),
                        Etpemail = c.Boolean(nullable: false),
                        Etpemisstxt = c.String(maxLength: 80),
                        Etpimpresstxt = c.String(maxLength: 80),
                        Etpemailtxt = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Trdfstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Docmodulo", "Trdfstamp", "dbo.Trdf");
            DropForeignKey("dbo.Docmodulo", "Trdstamp", "dbo.Trd");
            DropForeignKey("dbo.Docmodulo", "Trclstamp", "dbo.TRcl");
            DropForeignKey("dbo.Docmodulo", "Tdocfstamp", "dbo.Tdocf");
            DropForeignKey("dbo.Docmodulo", "Tdocstamp", "dbo.Tdoc");
            DropForeignKey("dbo.Docmodulo", "Tdistamp", "dbo.Tdi");
            DropForeignKey("dbo.Docmodulo", "Rltstamp", "dbo.Rlt");
            DropIndex("dbo.Docmodulo", new[] { "Trdfstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdocfstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Trdstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Trclstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdocstamp" });
            DropIndex("dbo.Docmodulo", new[] { "Tdistamp" });
            DropIndex("dbo.Docmodulo", new[] { "Rltstamp" });
            DropTable("dbo.Trdf");
            DropTable("dbo.Trd");
            DropTable("dbo.TRcl");
            DropTable("dbo.Rlt");
            DropTable("dbo.Docmodulo");
        }
    }
}
