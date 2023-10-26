namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTabelas : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cc", new[] { "rclstamp" });
            CreateTable(
                "dbo.Mstk",
                c => new
                    {
                        Mstkstamp = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(maxLength: 80),
                        Stampcab = c.String(maxLength: 80),
                        Origem = c.String(maxLength: 80),
                        data = c.DateTime(nullable: false),
                        Tipodoc = c.String(maxLength: 80),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Documento = c.String(maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ref = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        Entrada = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Saida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                        moeda = c.String(maxLength: 80),
                        Entidade = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(maxLength: 80),
                        Datahora = c.DateTime(nullable: false),
                        Lote = c.String(maxLength: 80),
                        Codmovstk = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovstk = c.String(maxLength: 80),
                        Numinterno = c.String(maxLength: 80),
                        Factstamp = c.String(maxLength: 80),
                        Faccstamp = c.String(maxLength: 80),
                        Distamp = c.String(maxLength: 80),
                        Ivstamp = c.String(maxLength: 80),
                        Factlstamp = c.String(maxLength: 80),
                        Facclstamp = c.String(maxLength: 80),
                        Dilstamp = c.String(maxLength: 80),
                        Ivlstamp = c.String(maxLength: 80),
                        Turno = c.String(maxLength: 80),
                        Vendedor = c.String(maxLength: 80),
                        Codvend = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Serie = c.String(maxLength: 80),
                        Ivainc = c.Boolean(nullable: false),
                        Tabiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco3 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lotevalid = c.DateTime(nullable: false),
                        Lotelimft = c.DateTime(nullable: false),
                        Usalote = c.Boolean(nullable: false),
                        Qttmedida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totalmedida = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Mstkstamp)
                .ForeignKey("dbo.Dil", t => t.Dilstamp)
                .ForeignKey("dbo.Factl", t => t.Factlstamp)
                .Index(t => t.Factlstamp)
                .Index(t => t.Dilstamp);
            
            CreateTable(
                "dbo.Dil",
                c => new
                    {
                        Dilstamp = c.String(nullable: false, maxLength: 80),
                        Distamp = c.String(maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(maxLength: 80),
                        Ref = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Unidade = c.String(maxLength: 80),
                        Armazem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Armazem2 = c.Decimal(nullable: false, precision: 9, scale: 0),
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
                        servico = c.Boolean(nullable: false),
                        nmovstk = c.Boolean(nullable: false),
                        remotestamp = c.String(maxLength: 80),
                        mpr = c.Boolean(nullable: false),
                        oristamp = c.String(maxLength: 80),
                        Tit = c.Boolean(nullable: false),
                        ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        stkprod = c.Boolean(nullable: false),
                        Titstamp = c.String(maxLength: 80),
                        usaserie = c.Boolean(nullable: false),
                        serie = c.String(maxLength: 80),
                        contatz = c.Decimal(precision: 9, scale: 0),
                        codstat = c.Decimal(precision: 9, scale: 0),
                        composto = c.Boolean(nullable: false),
                        usalote = c.Boolean(nullable: false),
                        pack = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nlinha = c.Decimal(precision: 9, scale: 0),
                        marcnum = c.String(maxLength: 80),
                        acordo = c.String(maxLength: 80),
                        peso = c.Decimal(precision: 9, scale: 0),
                        moedaf = c.String(maxLength: 80),
                        cambiol = c.Decimal(precision: 9, scale: 0),
                        fobme = c.Decimal(precision: 9, scale: 0),
                        freteme = c.Decimal(precision: 9, scale: 0),
                        segurome = c.Decimal(precision: 9, scale: 0),
                        ocusto = c.Decimal(precision: 9, scale: 0),
                        cifme = c.Decimal(precision: 9, scale: 0),
                        cifmt = c.Decimal(precision: 9, scale: 0),
                        oducifmt = c.Decimal(precision: 9, scale: 0),
                        tvolume = c.String(maxLength: 80),
                        qttvolumes = c.Decimal(precision: 9, scale: 0),
                        classe = c.String(maxLength: 80),
                        qttsuplim1 = c.Decimal(precision: 9, scale: 0),
                        qttsuplim2 = c.Decimal(precision: 9, scale: 0),
                        opais = c.String(maxLength: 80),
                        cproced = c.String(maxLength: 80),
                        licenca = c.String(maxLength: 80),
                        anexos = c.String(maxLength: 80),
                        docanter = c.String(maxLength: 80),
                        txdireire = c.Decimal(precision: 9, scale: 0),
                        tximpcons = c.Decimal(precision: 9, scale: 0),
                        txsobretx = c.Decimal(precision: 9, scale: 0),
                        vdireire = c.Decimal(precision: 9, scale: 0),
                        vimpcons = c.Decimal(precision: 9, scale: 0),
                        viva = c.Decimal(precision: 9, scale: 0),
                        vsobretx = c.Decimal(precision: 9, scale: 0),
                        pdireire = c.Decimal(precision: 9, scale: 0),
                        pimpcons = c.Decimal(precision: 9, scale: 0),
                        piva = c.Decimal(precision: 9, scale: 0),
                        psobretx = c.Decimal(precision: 9, scale: 0),
                        pagina = c.Decimal(precision: 9, scale: 0),
                        qualidade = c.String(maxLength: 80),
                        lotevalid = c.DateTime(nullable: false),
                        lotelimft = c.DateTime(nullable: false),
                        qttmedida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        totalmedida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        grupo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        usaperlinha = c.Boolean(nullable: false),
                        perlinha = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tipocheck = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Dilstamp)
                .ForeignKey("dbo.Di", t => t.Distamp)
                .Index(t => t.Distamp);
            
            CreateTable(
                "dbo.Di",
                c => new
                    {
                        Distamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(maxLength: 80),
                        Numinterno = c.String(maxLength: 80),
                        numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Entidade = c.Decimal(nullable: false, precision: 9, scale: 0),
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
                        Trf = c.Boolean(nullable: false),
                        Nomedoc = c.String(maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contatesoura = c.String(maxLength: 80),
                        Codmovstk = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovstk = c.String(maxLength: 80),
                        Reffornec = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        codmovstk2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descmovstk2 = c.String(maxLength: 80),
                        obs = c.String(maxLength: 80),
                        oristamp = c.String(maxLength: 80),
                        aprovado = c.Boolean(nullable: false),
                        codarm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descarm = c.String(maxLength: 80),
                        codarm2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descarm2 = c.String(maxLength: 80),
                        codturno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Turno = c.String(maxLength: 80),
                        clivainc = c.Boolean(nullable: false),
                        no2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome2 = c.String(maxLength: 80),
                        usaaprova = c.Boolean(nullable: false),
                        fechado = c.Boolean(nullable: false),
                        opcao1other = c.String(maxLength: 80),
                        pjno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        pjstamp = c.String(maxLength: 80),
                        orc = c.Boolean(nullable: false),
                        codcont = c.String(maxLength: 80),
                        codareap = c.String(maxLength: 80),
                        codfin = c.String(maxLength: 80),
                        codlfin = c.String(maxLength: 80),
                        tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        no3 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome3 = c.String(maxLength: 80),
                        no4 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome4 = c.String(maxLength: 80),
                        Mercadoria = c.String(maxLength: 80),
                        tprocess = c.String(maxLength: 80),
                        codproc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tservico = c.String(maxLength: 80),
                        Refcl = c.String(maxLength: 80),
                        nrfornec = c.String(maxLength: 80),
                        Fronteira = c.String(maxLength: 80),
                        Terminal = c.String(maxLength: 80),
                        Transp = c.String(maxLength: 80),
                        nrTransp = c.String(maxLength: 80),
                        Destino = c.String(maxLength: 80),
                        Moeda2 = c.String(maxLength: 80),
                        Fob = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Frete = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Seguro = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ocusto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        gdiversos = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Regular = c.Decimal(nullable: false, precision: 9, scale: 0),
                        dchegada = c.DateTime(nullable: false),
                        valmin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        matrTransp = c.String(maxLength: 80),
                        embarque = c.String(maxLength: 80),
                        volumes = c.String(maxLength: 80),
                        peso = c.String(maxLength: 80),
                        CIFMOEDA = c.Decimal(nullable: false, precision: 9, scale: 0),
                        CIFMT = c.Decimal(nullable: false, precision: 9, scale: 0),
                        dusequenc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        duitems = c.Decimal(nullable: false, precision: 9, scale: 0),
                        estancia = c.String(maxLength: 80),
                        regime = c.String(maxLength: 80),
                        manifesto = c.String(maxLength: 80),
                        doctransp = c.String(maxLength: 80),
                        nregtransp = c.String(maxLength: 80),
                        nvolumes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        pembarque = c.String(maxLength: 80),
                        nrcontpag = c.String(maxLength: 80),
                        portdest = c.String(maxLength: 80),
                        ngarant = c.String(maxLength: 80),
                        mgarant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        sgarant = c.String(maxLength: 80),
                        prdestino = c.String(maxLength: 80),
                        refdeclara = c.String(maxLength: 80),
                        metaval = c.Decimal(nullable: false, precision: 9, scale: 0),
                        formpagadc = c.String(maxLength: 80),
                        paisdest = c.String(maxLength: 80),
                        nacional = c.String(maxLength: 80),
                        locdescarg = c.String(maxLength: 80),
                        condentreg = c.String(maxLength: 80),
                        metpagament = c.Decimal(nullable: false, precision: 9, scale: 0),
                        fundo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        prevarmaz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        regarmaz = c.String(maxLength: 80),
                        outrinfo = c.String(maxLength: 80),
                        ptransp1 = c.String(maxLength: 80),
                        ptransp2 = c.String(maxLength: 80),
                        ptransp3 = c.String(maxLength: 80),
                        numselo = c.String(maxLength: 80),
                        pbruto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        outras = c.String(maxLength: 80),
                        ntims = c.Decimal(nullable: false, precision: 9, scale: 0),
                        refcambial = c.Decimal(nullable: false, precision: 9, scale: 0),
                        refprocur = c.Decimal(nullable: false, precision: 9, scale: 0),
                        reflicenc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nisencao = c.String(maxLength: 80),
                        datisencao = c.DateTime(nullable: false),
                        isdireito = c.String(maxLength: 80),
                        isimpcons = c.String(maxLength: 80),
                        issobretx = c.String(maxLength: 80),
                        isiva = c.String(maxLength: 80),
                        blegal = c.String(maxLength: 80),
                        Locmercador = c.String(maxLength: 80),
                        Proprietario = c.String(maxLength: 80),
                        desestancia = c.String(maxLength: 80),
                        desregime = c.String(maxLength: 80),
                        desfrnteira = c.String(maxLength: 80),
                        despembarque = c.String(maxLength: 80),
                        despdestino1 = c.String(maxLength: 80),
                        deslocdescarg = c.String(maxLength: 80),
                        descodentreg = c.String(maxLength: 80),
                        desmetpagam = c.String(maxLength: 80),
                        desfundo = c.String(maxLength: 80),
                        desptrans1 = c.String(maxLength: 80),
                        desptrans2 = c.String(maxLength: 80),
                        desptrans3 = c.String(maxLength: 80),
                        despdestinof = c.String(maxLength: 80),
                        desmeiotransp = c.String(maxLength: 80),
                        desblegal = c.String(maxLength: 80),
                        txDireito = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tximpcons = c.Decimal(nullable: false, precision: 9, scale: 0),
                        txsobretx = c.Decimal(nullable: false, precision: 9, scale: 0),
                        txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tipodu = c.Decimal(nullable: false, precision: 9, scale: 0),
                        refinterna = c.String(maxLength: 80),
                        tdistrib = c.Decimal(nullable: false, precision: 9, scale: 0),
                        PDireitos = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Pimpcons = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Psobretx = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Piva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        zeros = c.Decimal(nullable: false, precision: 9, scale: 0),
                        repfinanc = c.String(maxLength: 80),
                        Autorproj = c.String(maxLength: 80),
                        Autorcsta = c.String(maxLength: 80),
                        odisplegal = c.String(maxLength: 80),
                        displegal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        benef = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ArtGerais = c.String(maxLength: 80),
                        tipoagenc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        moznumber = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tpdescmercad = c.String(maxLength: 80),
                        tpcodmercad = c.Decimal(nullable: false, precision: 9, scale: 0),
                        pemb = c.Boolean(nullable: false),
                        adjud = c.Boolean(nullable: false),
                        datadjud = c.DateTime(nullable: false),
                        facc1stamp = c.String(maxLength: 80),
                        facc2stamp = c.String(maxLength: 80),
                        ndeclara = c.Decimal(nullable: false, precision: 9, scale: 0),
                        totpeso = c.Decimal(nullable: false, precision: 9, scale: 0),
                        totvolume = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        dEntrada = c.DateTime(nullable: false),
                        dCheckin = c.DateTime(nullable: false),
                        dPagamento = c.DateTime(nullable: false),
                        dExamin = c.DateTime(nullable: false),
                        dVerific = c.DateTime(nullable: false),
                        dPronto = c.DateTime(nullable: false),
                        cifusd = c.Decimal(nullable: false, precision: 9, scale: 0),
                        cambiousd = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DataFecho = c.DateTime(nullable: false),
                        calcfrete = c.Decimal(nullable: false, precision: 9, scale: 0),
                        calcseguro = c.Decimal(nullable: false, precision: 9, scale: 0),
                        inactivo = c.Boolean(nullable: false),
                        reserva = c.Boolean(nullable: false),
                        tipodoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        lant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        lact = c.Decimal(nullable: false, precision: 9, scale: 0),
                        lreal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ldata = c.DateTime(nullable: false),
                        tipoentida = c.String(maxLength: 80),
                        zona = c.String(maxLength: 80),
                        ncont = c.String(maxLength: 80),
                        codzona = c.Decimal(nullable: false, precision: 9, scale: 0),
                        fleitura = c.String(maxLength: 80),
                        estabno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        estabnome = c.String(maxLength: 80),
                        Morada = c.String(maxLength: 80),
                        Telefone = c.String(maxLength: 80),
                        fax = c.String(maxLength: 80),
                        nuit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        email = c.String(maxLength: 80),
                        optintro = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Distamp);
            
            CreateTable(
                "dbo.Dil3",
                c => new
                    {
                        Dil3Stamp = c.String(nullable: false, maxLength: 80),
                        Cod = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Distamp = c.String(maxLength: 80),
                        Intertekstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Dil3Stamp)
                .ForeignKey("dbo.Di", t => t.Distamp)
                .Index(t => t.Distamp);
            
            CreateTable(
                "dbo.Pgf",
                c => new
                    {
                        Pgfstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome = c.String(maxLength: 80),
                        moeda = c.String(maxLength: 80),
                        Banco = c.String(maxLength: 80),
                        total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        mtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(maxLength: 80),
                        process = c.Boolean(nullable: false),
                        dprocess = c.DateTime(nullable: false),
                        anulado = c.Boolean(nullable: false),
                        ccusto = c.String(maxLength: 80),
                        NrFornec = c.String(maxLength: 80),
                        numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        sigla = c.String(maxLength: 80),
                        nomedoc = c.String(maxLength: 80),
                        codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descmovcc = c.String(maxLength: 80),
                        integra = c.Boolean(nullable: false),
                        nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        diario = c.String(maxLength: 80),
                        ndocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descDocCont = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Pgfstamp);
            
            CreateTable(
                "dbo.Rdf",
                c => new
                    {
                        Rdfstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        data = c.DateTime(nullable: false),
                        no = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome = c.String(maxLength: 80),
                        moeda = c.String(maxLength: 80),
                        Banco = c.String(maxLength: 80),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(maxLength: 80),
                        Bancoprov = c.String(maxLength: 80),
                        Titulo = c.String(maxLength: 80),
                        Numtitulo = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(maxLength: 80),
                        Nomedoc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovcc = c.String(maxLength: 80),
                        Anulado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Rdfstamp);
            
            CreateTable(
                "dbo.Rdfl",
                c => new
                    {
                        Rdflstamp = c.String(nullable: false, maxLength: 80),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Valorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mvalorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Rdfstamp = c.String(maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Rdflstamp)
                .ForeignKey("dbo.Rdf", t => t.Rdfstamp)
                .Index(t => t.Rdfstamp);
            
            CreateTable(
                "dbo.Rd",
                c => new
                    {
                        Rdstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(maxLength: 80),
                        Moeda = c.String(maxLength: 80),
                        Banco = c.String(maxLength: 80),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(maxLength: 80),
                        bancoprov = c.String(maxLength: 80),
                        anulado = c.Boolean(nullable: false),
                        ccusto = c.String(maxLength: 80),
                        numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        sigla = c.String(maxLength: 80),
                        Nomedoc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovcc = c.String(maxLength: 80),
                        Nomecomerc = c.String(maxLength: 80),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(maxLength: 80),
                        Estabno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estabnome = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Rdstamp);
            
            CreateTable(
                "dbo.Rdl",
                c => new
                    {
                        Rdstamp = c.String(nullable: false, maxLength: 80),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        valorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mvalorl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Rdlstamp = c.String(maxLength: 80),
                        Status = c.Boolean(nullable: false),
                        Rd_Rdstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Rdstamp)
                .ForeignKey("dbo.Rd", t => t.Rd_Rdstamp)
                .Index(t => t.Rd_Rdstamp);
            
            CreateTable(
                "dbo.Tdi",
                c => new
                    {
                        Tdistamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desctipo = c.String(maxLength: 80),
                        tiposigla = c.String(maxLength: 80),
                        Alteranum = c.Boolean(nullable: false),
                        ctrlData = c.Boolean(nullable: false),
                        Armazem = c.Boolean(nullable: false),
                        armdefeito = c.Decimal(nullable: false, precision: 9, scale: 0),
                        movstk = c.Boolean(nullable: false),
                        codmovstk = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovstk = c.String(maxLength: 80),
                        Composto = c.Boolean(nullable: false),
                        Obgccusto = c.Boolean(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Defa = c.Boolean(nullable: false),
                        trf = c.Boolean(nullable: false),
                        codmovstk2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descmovstk2 = c.String(maxLength: 80),
                        numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        reserva = c.Boolean(nullable: false),
                        noneg = c.Boolean(nullable: false),
                        Armapenas = c.Boolean(nullable: false),
                        prod = c.Boolean(nullable: false),
                        Copyqtt = c.Boolean(nullable: false),
                        copyvalor = c.Boolean(nullable: false),
                        prccusto = c.Boolean(nullable: false),
                        armdefeito2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Facturar = c.Boolean(nullable: false),
                        ndocfact = c.Decimal(nullable: false, precision: 9, scale: 0),
                        docfact = c.String(maxLength: 80),
                        CopiaDocs = c.Boolean(nullable: false),
                        Nomfile = c.String(maxLength: 80),
                        ecran = c.String(maxLength: 80),
                        Titimpress = c.String(maxLength: 80),
                        copia = c.Boolean(nullable: false),
                        usaaprova = c.Boolean(nullable: false),
                        descpreco = c.String(maxLength: 80),
                        campopreco = c.String(maxLength: 80),
                        usafecho = c.Boolean(nullable: false),
                        no = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome = c.String(maxLength: 80),
                        usaemail = c.Boolean(nullable: false),
                        destinationEmail = c.String(maxLength: 80),
                        subj = c.String(maxLength: 80),
                        emailText = c.String(maxLength: 80),
                        usaattach = c.Boolean(nullable: false),
                        usaorigem = c.Boolean(nullable: false),
                        usadestino = c.Boolean(nullable: false),
                        usaanexo = c.Boolean(nullable: false),
                        ligapj = c.Boolean(nullable: false),
                        Obrigapj = c.Boolean(nullable: false),
                        Usaserie = c.Boolean(nullable: false),
                        Autoemail = c.Boolean(nullable: false),
                        Condcopia = c.String(maxLength: 80),
                        Orc = c.Boolean(nullable: false),
                        Movtz = c.Boolean(nullable: false),
                        tipomovtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        noentid = c.Boolean(nullable: false),
                        regrd = c.Boolean(nullable: false),
                        usalote = c.Boolean(nullable: false),
                        dotacao = c.Boolean(nullable: false),
                        aprova = c.Boolean(nullable: false),
                        maskqtt = c.String(maxLength: 80),
                        maskpreco = c.String(maxLength: 80),
                        maskoprecos = c.String(maxLength: 80),
                        expressemidoc = c.String(maxLength: 80),
                        expresstitulo = c.String(maxLength: 80),
                        Introdir = c.Boolean(nullable: false),
                        tipodoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        pastascan = c.String(maxLength: 80),
                        tipoimg = c.String(maxLength: 80),
                        saveimg = c.Boolean(nullable: false),
                        nomefiles = c.String(maxLength: 80),
                        usatec = c.Boolean(nullable: false),
                        nopergtec = c.Boolean(nullable: false),
                        obrigalote = c.Boolean(nullable: false),
                        usaqttmedida = c.Boolean(nullable: false),
                        descqttmedida = c.String(maxLength: 80),
                        noalteramedida = c.Boolean(nullable: false),
                        dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ccusto = c.String(maxLength: 80),
                        contastesoura = c.String(maxLength: 80),
                        codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        titulo = c.String(maxLength: 80),
                        nalteratz = c.Boolean(nullable: false),
                        diagua = c.Boolean(nullable: false),
                        etpemiss = c.Boolean(nullable: false),
                        etpimpress = c.Boolean(nullable: false),
                        etpemail = c.Boolean(nullable: false),
                        etpemisstxt = c.String(maxLength: 80),
                        etpimpresstxt = c.String(maxLength: 80),
                        etpemailtxt = c.String(maxLength: 80),
                        ctrqttorig = c.Boolean(nullable: false),
                        precocl = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Tdistamp);
            
            AddColumn("dbo.Factl", "Usalote", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Ligapj", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Obrigapj", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Usaserie", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Usalote", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Integra", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "NoDiario", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdoc", "Diario", c => c.String(maxLength: 80));
            AddColumn("dbo.Tdoc", "NDocCont", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdoc", "Descdoccont", c => c.String(maxLength: 80));
            AddColumn("dbo.Tdoc", "TesouraPgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            CreateIndex("dbo.Cc", "Rclstamp");
            CreateIndex("dbo.Cc", "Rdstamp");
            CreateIndex("dbo.Formasp", "Rdstamp");
            CreateIndex("dbo.Formasp", "Pgfstamp");
            CreateIndex("dbo.Formasp", "Rdfstamp");
            CreateIndex("dbo.Fcc", "Pgfstamp");
            CreateIndex("dbo.Fcc", "Rdfstamp");
            AddForeignKey("dbo.Fcc", "Pgfstamp", "dbo.Pgf", "Pgfstamp");
            AddForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf", "Rdfstamp");
            AddForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf", "Rdfstamp");
            AddForeignKey("dbo.Formasp", "Pgfstamp", "dbo.Pgf", "Pgfstamp");
            AddForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd", "Rdstamp");
            AddForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd", "Rdstamp");
            DropColumn("dbo.Fcc", "qmc");
            DropColumn("dbo.Fcc", "qmcdathora");
            DropColumn("dbo.Fcc", "qma");
            DropColumn("dbo.Fcc", "qmadathora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fcc", "qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fcc", "qma", c => c.String(maxLength: 80));
            AddColumn("dbo.Fcc", "qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Fcc", "qmc", c => c.String(maxLength: 80));
            DropForeignKey("dbo.Rdl", "Rd_Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Formasp", "Pgfstamp", "dbo.Pgf");
            DropForeignKey("dbo.Rdfl", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Fcc", "Pgfstamp", "dbo.Pgf");
            DropForeignKey("dbo.Mstk", "Factlstamp", "dbo.Factl");
            DropForeignKey("dbo.Mstk", "Dilstamp", "dbo.Dil");
            DropForeignKey("dbo.Dil3", "Distamp", "dbo.Di");
            DropForeignKey("dbo.Dil", "Distamp", "dbo.Di");
            DropIndex("dbo.Rdl", new[] { "Rd_Rdstamp" });
            DropIndex("dbo.Rdfl", new[] { "Rdfstamp" });
            DropIndex("dbo.Fcc", new[] { "Rdfstamp" });
            DropIndex("dbo.Fcc", new[] { "Pgfstamp" });
            DropIndex("dbo.Formasp", new[] { "Rdfstamp" });
            DropIndex("dbo.Formasp", new[] { "Pgfstamp" });
            DropIndex("dbo.Formasp", new[] { "Rdstamp" });
            DropIndex("dbo.Dil3", new[] { "Distamp" });
            DropIndex("dbo.Dil", new[] { "Distamp" });
            DropIndex("dbo.Mstk", new[] { "Dilstamp" });
            DropIndex("dbo.Mstk", new[] { "Factlstamp" });
            DropIndex("dbo.Cc", new[] { "Rdstamp" });
            DropIndex("dbo.Cc", new[] { "Rclstamp" });
            DropColumn("dbo.Tdoc", "TesouraPgc");
            DropColumn("dbo.Tdoc", "Descdoccont");
            DropColumn("dbo.Tdoc", "NDocCont");
            DropColumn("dbo.Tdoc", "Diario");
            DropColumn("dbo.Tdoc", "NoDiario");
            DropColumn("dbo.Tdoc", "Integra");
            DropColumn("dbo.Tdoc", "Usalote");
            DropColumn("dbo.Tdoc", "Usaserie");
            DropColumn("dbo.Tdoc", "Obrigapj");
            DropColumn("dbo.Tdoc", "Ligapj");
            DropColumn("dbo.Factl", "Usalote");
            DropTable("dbo.Tdi");
            DropTable("dbo.Rdl");
            DropTable("dbo.Rd");
            DropTable("dbo.Rdfl");
            DropTable("dbo.Rdf");
            DropTable("dbo.Pgf");
            DropTable("dbo.Dil3");
            DropTable("dbo.Di");
            DropTable("dbo.Dil");
            DropTable("dbo.Mstk");
            CreateIndex("dbo.Cc", "rclstamp");
        }
    }
}
