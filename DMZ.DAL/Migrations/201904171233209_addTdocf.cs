namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTdocf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facc",
                c => new
                    {
                        Faccstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        Dataven = c.DateTime(nullable: false),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(maxLength: 80),
                        Moeda = c.String(maxLength: 80),
                        Subtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Perdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desconto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totaliva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Msubtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mdesconto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotaliva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codvend = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vendedor = c.String(maxLength: 80),
                        Cambio = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cambfixo = c.Boolean(nullable: false),
                        Impresso = c.Boolean(nullable: false),
                        Usrimpress = c.String(maxLength: 80),
                        Impressodh = c.DateTime(nullable: false),
                        Anulado = c.Boolean(nullable: false),
                        CodInterno = c.String(maxLength: 80),
                        Movtz = c.Boolean(nullable: false),
                        Movstk = c.Boolean(nullable: false),
                        Movcc = c.Boolean(nullable: false),
                        Nomedoc = c.String(maxLength: 80),
                        Codmovstk = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovstk = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovcc = c.String(maxLength: 80),
                        Numinterno = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        obs = c.String(maxLength: 80),
                        Oristamp = c.String(maxLength: 80),
                        Aprovado = c.Boolean(nullable: false),
                        Clivainc = c.Boolean(nullable: false),
                        Tipodoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Custos = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Calc = c.Boolean(nullable: false),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(maxLength: 80),
                        Reserva = c.Boolean(nullable: false),
                        Codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome2 = c.String(maxLength: 80),
                        Tprocess = c.String(maxLength: 80),
                        Nrordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nrtimms = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Numreceita = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Refpagam = c.String(maxLength: 80),
                        Ndeclara = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Faccstamp);
            
            CreateTable(
                "dbo.Faccl",
                c => new
                    {
                        Facclstamp = c.String(nullable: false, maxLength: 80),
                        Faccstamp = c.String(maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(maxLength: 80),
                        Ref = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Unidade = c.String(maxLength: 80),
                        Armazem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mpreco = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lote = c.String(maxLength: 80),
                        Tabiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valival = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mvalival = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ivainc = c.Boolean(nullable: false),
                        Perdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descontol = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mdescontol = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Subtotall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Msubtotall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Status = c.Boolean(nullable: false),
                        Usadesign = c.Boolean(nullable: false),
                        Servico = c.Boolean(nullable: false),
                        Nmovstk = c.Boolean(nullable: false),
                        Remotestamp = c.String(maxLength: 80),
                        Oristamp = c.String(maxLength: 80),
                        Tit = c.Boolean(nullable: false),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Stkprod = c.Boolean(nullable: false),
                        Titstamp = c.String(maxLength: 80),
                        Contatz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cpoo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Reffornecl = c.String(maxLength: 80),
                        Composto = c.Boolean(nullable: false),
                        Usalote = c.Boolean(nullable: false),
                        Pack = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lotevalid = c.DateTime(nullable: false),
                        Lotelimft = c.DateTime(nullable: false),
                        Qttmedida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totalmedida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Grupo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Usaperlinha = c.Boolean(nullable: false),
                        Perlinha = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipocheck = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Facclstamp)
                .ForeignKey("dbo.Facc", t => t.Faccstamp)
                .Index(t => t.Faccstamp);
            
            CreateTable(
                "dbo.Faccprest",
                c => new
                    {
                        Faccpreststamp = c.String(nullable: false, maxLength: 80),
                        Faccstamp = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Perc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Faccpreststamp)
                .ForeignKey("dbo.Facc", t => t.Faccstamp)
                .Index(t => t.Faccstamp);
            
            CreateTable(
                "dbo.Tdocf",
                c => new
                    {
                        Tdocfstamp = c.String(nullable: false, maxLength: 80),
                        numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descricao = c.String(maxLength: 80),
                        sigla = c.String(maxLength: 80),
                        Alteranum = c.Boolean(nullable: false),
                        ctrlData = c.Boolean(nullable: false),
                        ctrlPlaf = c.Boolean(nullable: false),
                        Armazem = c.Boolean(nullable: false),
                        armdefeito = c.Decimal(nullable: false, precision: 9, scale: 0),
                        movstk = c.Boolean(nullable: false),
                        codmovstk = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descmovstk = c.String(maxLength: 80),
                        movcc = c.Boolean(nullable: false),
                        descmovcc = c.String(maxLength: 80),
                        codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        recibo = c.Boolean(nullable: false),
                        movtes = c.Boolean(nullable: false),
                        Composto = c.Boolean(nullable: false),
                        obgccusto = c.Boolean(nullable: false),
                        codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        contastesoura = c.String(maxLength: 80),
                        movtz = c.Boolean(nullable: false),
                        nalteratz = c.Boolean(nullable: false),
                        activo = c.Boolean(nullable: false),
                        defa = c.Boolean(nullable: false),
                        reserva = c.Boolean(nullable: false),
                        noneg = c.Boolean(nullable: false),
                        Armapenas = c.Boolean(nullable: false),
                        Copyqtt = c.Boolean(nullable: false),
                        copyvalor = c.Boolean(nullable: false),
                        titulo = c.String(maxLength: 80),
                        Facturar = c.Boolean(nullable: false),
                        ndocfact = c.Decimal(nullable: false, precision: 9, scale: 0),
                        docfact = c.String(maxLength: 80),
                        CopiaDocs = c.Boolean(nullable: false),
                        Nomfile = c.String(maxLength: 80),
                        ecran = c.String(maxLength: 80),
                        Titimpress = c.String(maxLength: 80),
                        descpreco = c.String(maxLength: 80),
                        campopreco = c.String(maxLength: 80),
                        no = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome = c.String(maxLength: 80),
                        usaemail = c.Boolean(nullable: false),
                        usaanexo = c.Boolean(nullable: false),
                        ligapj = c.Boolean(nullable: false),
                        obrigapj = c.Boolean(nullable: false),
                        usaserie = c.Boolean(nullable: false),
                        tipodoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        prestacao = c.Boolean(nullable: false),
                        usalote = c.Boolean(nullable: false),
                        dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        adjudica = c.Boolean(nullable: false),
                        aprova = c.Boolean(nullable: false),
                        integra = c.Boolean(nullable: false),
                        nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        diario = c.String(maxLength: 80),
                        ndocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descDocCont = c.String(maxLength: 80),
                        maskqtt = c.String(maxLength: 80),
                        maskpreco = c.String(maxLength: 80),
                        maskoprecos = c.String(maxLength: 80),
                        expressemidoc = c.String(maxLength: 80),
                        expresstitulo = c.String(maxLength: 80),
                        tesouraPgc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        usatec = c.Boolean(nullable: false),
                        nopergtec = c.Boolean(nullable: false),
                        obrigalote = c.Boolean(nullable: false),
                        usaqttmedida = c.Boolean(nullable: false),
                        descqttmedida = c.String(maxLength: 80),
                        noalteramedida = c.Boolean(nullable: false),
                        ccusto = c.String(maxLength: 80),
                        etpemiss = c.Boolean(nullable: false),
                        etpimpress = c.Boolean(nullable: false),
                        etpemail = c.Boolean(nullable: false),
                        etpemisstxt = c.String(maxLength: 80),
                        etpimpresstxt = c.String(maxLength: 80),
                        etpemailtxt = c.String(maxLength: 80),
                        ctrqttorig = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Tdocfstamp);
            
            CreateIndex("dbo.Mstk", "Facclstamp");
            CreateIndex("dbo.Formasp", "Faccstamp");
            CreateIndex("dbo.Fcc", "Faccstamp");
            AddForeignKey("dbo.Mstk", "Facclstamp", "dbo.Faccl", "Facclstamp");
            AddForeignKey("dbo.Fcc", "Faccstamp", "dbo.Facc", "Faccstamp");
            AddForeignKey("dbo.Formasp", "Faccstamp", "dbo.Facc", "Faccstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formasp", "Faccstamp", "dbo.Facc");
            DropForeignKey("dbo.Fcc", "Faccstamp", "dbo.Facc");
            DropForeignKey("dbo.Faccprest", "Faccstamp", "dbo.Facc");
            DropForeignKey("dbo.Mstk", "Facclstamp", "dbo.Faccl");
            DropForeignKey("dbo.Faccl", "Faccstamp", "dbo.Facc");
            DropIndex("dbo.Faccprest", new[] { "Faccstamp" });
            DropIndex("dbo.Faccl", new[] { "Faccstamp" });
            DropIndex("dbo.Fcc", new[] { "Faccstamp" });
            DropIndex("dbo.Formasp", new[] { "Faccstamp" });
            DropIndex("dbo.Mstk", new[] { "Facclstamp" });
            DropTable("dbo.Tdocf");
            DropTable("dbo.Faccprest");
            DropTable("dbo.Faccl");
            DropTable("dbo.Facc");
        }
    }
}
