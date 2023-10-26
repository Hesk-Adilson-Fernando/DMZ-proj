namespace DMZ.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class BigUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apivded",
                c => new
                    {
                        Apivdedlstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Apparamstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Apivdedlstamp)
                .ForeignKey("dbo.Apparam", t => t.Apparamstamp, cascadeDelete: true)
                .Index(t => t.Apparamstamp);
            
            CreateTable(
                "dbo.Apparam",
                c => new
                    {
                        Apparamstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Cc1 = c.String(nullable: false, maxLength: 80),
                        Cc2 = c.String(nullable: false, maxLength: 80),
                        Cc3 = c.String(nullable: false, maxLength: 80),
                        Qmc = c.String(nullable: false, maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(nullable: false, maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                        Ivarec = c.String(nullable: false, maxLength: 80),
                        Ivaant = c.String(nullable: false, maxLength: 80),
                        Ivapag = c.String(nullable: false, maxLength: 80),
                        Origem = c.String(nullable: false, maxLength: 80),
                        Cmesant = c.String(nullable: false, maxLength: 80),
                        Desmesant = c.String(nullable: false, maxLength: 80),
                        Sequec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tiposaldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Apparamstamp);
            
            CreateTable(
                "dbo.Apivliq",
                c => new
                    {
                        Apivliqlstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Apparamstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Apivliqlstamp)
                .ForeignKey("dbo.Apparam", t => t.Apparamstamp, cascadeDelete: true)
                .Index(t => t.Apparamstamp);
            
            CreateTable(
                "dbo.EmpresaMod",
                c => new
                    {
                        EmpresaModstamp = c.String(nullable: false, maxLength: 80),
                        Empresastamp = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Validade = c.DateTime(nullable: false),
                        Trial = c.Boolean(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.EmpresaModstamp)
                .ForeignKey("dbo.Empresa", t => t.Empresastamp, cascadeDelete: true)
                .Index(t => t.Empresastamp);
            
            CreateTable(
                "dbo.Mescont",
                c => new
                    {
                        Mescontstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Nomemes = c.String(nullable: false, maxLength: 80),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Qmc = c.String(nullable: false, maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(nullable: false, maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Mescontstamp);
            
            CreateTable(
                "dbo.ParamImp",
                c => new
                    {
                        ParamImpstamp = c.String(nullable: false, maxLength: 80),
                        Paramstamp = c.String(nullable: false, maxLength: 80),
                        Pos = c.String(nullable: false, maxLength: 80),
                        Normal1 = c.String(nullable: false, maxLength: 80),
                        Normal2 = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Codccu = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ParamImpstamp)
                .ForeignKey("dbo.Param", t => t.Paramstamp, cascadeDelete: true)
                .Index(t => t.Paramstamp);
            
            CreateTable(
                "dbo.Pgcsa",
                c => new
                    {
                        Conta = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Pgcsastamp = c.String(nullable: false, maxLength: 80),
                        Deb = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cre = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => new { t.Conta, t.Ano, t.Mes });
            
            CreateTable(
                "dbo.Reserva",
                c => new
                    {
                        Reservastamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Datain = c.DateTime(nullable: false),
                        Datafim = c.DateTime(nullable: false),
                        Horain = c.DateTime(nullable: false),
                        Horafim = c.DateTime(nullable: false),
                        Taxa = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Reservastamp);
            
            CreateTable(
                "dbo.Reserval",
                c => new
                    {
                        Reservalstamp = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Reservastamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Reservalstamp)
                .ForeignKey("dbo.Reserva", t => t.Reservastamp, cascadeDelete: true)
                .Index(t => t.Reservastamp);
            
            CreateTable(
                "dbo.UsrAudit",
                c => new
                    {
                        UsrAuditstamp = c.String(nullable: false, maxLength: 80),
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        Oristamp = c.String(nullable: false, maxLength: 80),
                        DataAdd = c.DateTime(nullable: false),
                        DataUpd = c.DateTime(nullable: false),
                        FormName = c.String(nullable: false, maxLength: 80),
                        DocName = c.String(nullable: false, maxLength: 80),
                        DocSigla = c.String(nullable: false, maxLength: 80),
                        DocNumero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Coment = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.UsrAuditstamp)
                .ForeignKey("dbo.Usr", t => t.Usrstamp, cascadeDelete: true)
                .Index(t => t.Usrstamp);
            
            AddColumn("dbo.Caixa", "Entrada", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixa", "Saida", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixa", "TotalCaixa", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Dil", "Processado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Di", "Encomenda", c => c.Boolean(nullable: false));
            AddColumn("dbo.Di", "Reserva", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgf", "Cambiousd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pgf", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgfl", "ValorPend", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pgfl", "MvalorPend", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pgfl", "Valordoc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pgfl", "Anulado", c => c.Boolean(nullable: false));
            AddColumn("dbo.RCL", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.RCL", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Cambiousd", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.RCL", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rcll", "Valordoc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Rcll", "ValorPend", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Rcll", "MvalorPend", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Contas", "Swift", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "Iban", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "VernaFactura", c => c.Boolean(nullable: false));
            AddColumn("dbo.Contas", "CodCcu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "VisivelPOS", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Encomenda", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Nd", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Ft", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Vd", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Usamascara", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Mascara", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Nc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Nd", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Ft", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Vd", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tpgf", "Nomfile", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Nomfile", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Empresa", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Empresa", "Capitalsocial", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Empresa", "Matricula", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Lcont", "Docno", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Lcont", "Moeda2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Usames", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Contmascara", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Fncpgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "Clpgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "Mostranib", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teste", "Descricao2", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.Teste", "NumDecimal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Factl", "Contatz", c => c.Decimal(nullable: false, precision: 9, scale: 0,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: null, newValue: "0")
                    },
                }));
            AlterColumn("dbo.Dil", "cambiol", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Subtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Perdesc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Desconto", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Totaliva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Msubtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Mdesconto", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Mtotaliva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Di", "Mtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgfl", "Valorpreg", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgfl", "Valorreg", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgfl", "Mvalorpreg", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pgfl", "Mvalorreg", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Dcli", "factor", c => c.Decimal(nullable: false, precision: 16, scale: 6));
            AlterColumn("dbo.Lcont", "Debana", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "debord", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Debfin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Creana", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Creord", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Crefin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Edebana", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Edebord", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Edebfin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Ecreana", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Ecreord", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Lcont", "Ecrefin", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Ml", "Deb", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Ml", "Cre", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Ml", "Edeb", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Ml", "Ecre", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.UsrModulo", "Codigo", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.UsrModulo", "Usrstamp");
            AddForeignKey("dbo.UsrModulo", "Usrstamp", "dbo.Usr", "Usrstamp", cascadeDelete: true);
            DropColumn("dbo.Caixa", "qma");
            DropColumn("dbo.Caixa", "qmadathora");
            DropColumn("dbo.Dil", "mpr");
            DropColumn("dbo.Dil", "codstat");
            DropColumn("dbo.Dil", "Pack");
            DropColumn("dbo.Dil", "nlinha");
            DropColumn("dbo.Dil", "marcnum");
            DropColumn("dbo.Dil", "Peso");
            DropColumn("dbo.Dil", "moedaf");
            DropColumn("dbo.Dil", "fobme");
            DropColumn("dbo.Dil", "freteme");
            DropColumn("dbo.Dil", "segurome");
            DropColumn("dbo.Dil", "ocusto");
            DropColumn("dbo.Dil", "cifme");
            DropColumn("dbo.Dil", "cifmt");
            DropColumn("dbo.Dil", "oducifmt");
            DropColumn("dbo.Dil", "tvolume");
            DropColumn("dbo.Dil", "qttvolumes");
            DropColumn("dbo.Dil", "classe");
            DropColumn("dbo.Dil", "qttsuplim1");
            DropColumn("dbo.Dil", "qttsuplim2");
            DropColumn("dbo.Dil", "opais");
            DropColumn("dbo.Dil", "cproced");
            DropColumn("dbo.Dil", "licenca");
            DropColumn("dbo.Dil", "anexos");
            DropColumn("dbo.Dil", "docanter");
            DropColumn("dbo.Dil", "Txdireire");
            DropColumn("dbo.Dil", "Tximpcons");
            DropColumn("dbo.Dil", "Txsobretx");
            DropColumn("dbo.Dil", "Vdireire");
            DropColumn("dbo.Dil", "vimpcons");
            DropColumn("dbo.Dil", "viva");
            DropColumn("dbo.Dil", "vsobretx");
            DropColumn("dbo.Dil", "pdireire");
            DropColumn("dbo.Dil", "pimpcons");
            DropColumn("dbo.Dil", "piva");
            DropColumn("dbo.Dil", "psobretx");
            DropColumn("dbo.Dil", "pagina");
            DropColumn("dbo.Dil", "qualidade");
            DropColumn("dbo.Dil", "lotevalid");
            DropColumn("dbo.Dil", "Lotelimft");
            DropColumn("dbo.Dil", "Qttmedida");
            DropColumn("dbo.Dil", "Totalmedida");
            DropColumn("dbo.Dil", "Grupo");
            DropColumn("dbo.Dil", "Usaperlinha");
            DropColumn("dbo.Dil", "Perlinha");
            DropColumn("dbo.Dil", "Tipocheck");
            DropColumn("dbo.Di", "Impresso");
            DropColumn("dbo.Di", "Usrimpress");
            DropColumn("dbo.Di", "Impressodh");
            DropColumn("dbo.Di", "CodInterno");
            DropColumn("dbo.Di", "Turno");
            DropColumn("dbo.Di", "Codcont");
            DropColumn("dbo.Di", "Codareap");
            DropColumn("dbo.Di", "Codfin");
            DropColumn("dbo.Di", "Codlfin");
            DropColumn("dbo.Di", "tprocess");
            DropColumn("dbo.Di", "codproc");
            DropColumn("dbo.Di", "tservico");
            DropColumn("dbo.Di", "Fronteira");
            DropColumn("dbo.Di", "Terminal");
            DropColumn("dbo.Di", "Transp");
            DropColumn("dbo.Di", "nrTransp");
            DropColumn("dbo.Di", "Fob");
            DropColumn("dbo.Di", "Frete");
            DropColumn("dbo.Di", "ocusto");
            DropColumn("dbo.Di", "gdiversos");
            DropColumn("dbo.Di", "Regular");
            DropColumn("dbo.Di", "valmin");
            DropColumn("dbo.Di", "matrTransp");
            DropColumn("dbo.Di", "embarque");
            DropColumn("dbo.Di", "volumes");
            DropColumn("dbo.Di", "peso");
            DropColumn("dbo.Di", "CIFMOEDA");
            DropColumn("dbo.Di", "CIFMT");
            DropColumn("dbo.Tdi", "Dotacao");
            DropColumn("dbo.Tdoc", "CtrlPlaf");
            DropColumn("dbo.Tdoc", "Recibo");
            DropColumn("dbo.Tdoc", "Movtes");
            DropColumn("dbo.Tdoc", "Qmc");
            DropColumn("dbo.Tdoc", "Qmcdathora");
            DropColumn("dbo.Tdoc", "Qma");
            DropColumn("dbo.Tdoc", "Qmadathora");
            DropColumn("dbo.Tdoc", "Introdir");
            DropColumn("dbo.Tdoc", "Copia");
            DropColumn("dbo.Tdoc", "Copyqtt");
            DropColumn("dbo.Tdoc", "Copyvalor");
            DropColumn("dbo.Tdoc", "Prestacao");
            DropColumn("dbo.Tdoc", "Facturar");
            DropColumn("dbo.Tdoc", "ndocfact");
            DropColumn("dbo.Tdoc", "docfact");
            DropColumn("dbo.Tdoc", "CopiaDocs");
            DropColumn("dbo.Tdoc", "Descdoc");
            DropColumn("dbo.Tdoc", "Noimp");
            DropColumn("dbo.Tdoc", "Ecran");
            DropColumn("dbo.Tdoc", "Titimpress");
            DropColumn("dbo.Tdoc", "Descpreco");
            DropColumn("dbo.Tdoc", "Campopreco");
            DropColumn("dbo.Tdoc", "Usaemail");
            DropColumn("dbo.Tdoc", "Usaanexo");
            DropColumn("dbo.Tdoc", "Expressemidoc");
            DropColumn("dbo.Tdoc", "Expresstitulo");
            DropColumn("dbo.Tdoc", "Autoemail");
            DropColumn("dbo.Tdoc", "Usaattach");
            DropColumn("dbo.Tdoc", "DestinationEmail");
            DropColumn("dbo.Tdoc", "Subj");
            DropColumn("dbo.Tdoc", "EmailText");
            DropColumn("dbo.Tdoc", "TesouraPgc");
            DropColumn("dbo.Tdoc", "Maskqtt");
            DropColumn("dbo.Tdoc", "Maskpreco");
            DropColumn("dbo.Tdoc", "Maskoprecos");
            DropColumn("dbo.Tdoc", "Usatec");
            DropColumn("dbo.Tdoc", "Nopergtec");
            DropColumn("dbo.Tdoc", "Obrigalote");
            DropColumn("dbo.Tdoc", "Usaqttmedida");
            DropColumn("dbo.Tdoc", "Descqttmedida");
            DropColumn("dbo.Tdoc", "Noalteramedida");
            DropColumn("dbo.Tdoc", "Etpemiss");
            DropColumn("dbo.Tdoc", "Etpimpress");
            DropColumn("dbo.Tdoc", "Etpemail");
            DropColumn("dbo.Tdoc", "Etpemisstxt");
            DropColumn("dbo.Tdoc", "Etpimpresstxt");
            DropColumn("dbo.Tdoc", "Etpemailtxt");
            DropColumn("dbo.Tdoc", "Ctrqttorig");
            DropColumn("dbo.Tdocf", "CtrlPlaf");
            DropColumn("dbo.Tdocf", "Movtes");
            DropColumn("dbo.Tdocf", "Nalteratz");
            DropColumn("dbo.Tdocf", "Copyqtt");
            DropColumn("dbo.Tdocf", "Copyvalor");
            DropColumn("dbo.Tdocf", "Titulo");
            DropColumn("dbo.Tdocf", "Facturar");
            DropColumn("dbo.Tdocf", "Ndocfact");
            DropColumn("dbo.Tdocf", "Docfact");
            DropColumn("dbo.Tdocf", "CopiaDocs");
            DropColumn("dbo.Tdocf", "Ecran");
            DropColumn("dbo.Tdocf", "Titimpress");
            DropColumn("dbo.Tdocf", "Descpreco");
            DropColumn("dbo.Tdocf", "Campopreco");
            DropColumn("dbo.Tdocf", "Usaemail");
            DropColumn("dbo.Tdocf", "Usaanexo");
            DropColumn("dbo.Tdocf", "Prestacao");
            DropColumn("dbo.Tdocf", "Dias");
            DropColumn("dbo.Tdocf", "Adjudica");
            DropColumn("dbo.Tdocf", "Aprova");
            DropColumn("dbo.Tdocf", "Maskqtt");
            DropColumn("dbo.Tdocf", "Maskpreco");
            DropColumn("dbo.Tdocf", "Maskoprecos");
            DropColumn("dbo.Tdocf", "Expressemidoc");
            DropColumn("dbo.Tdocf", "Expresstitulo");
            DropColumn("dbo.Tdocf", "Usatec");
            DropColumn("dbo.Tdocf", "Nopergtec");
            DropColumn("dbo.Tdocf", "Obrigalote");
            DropColumn("dbo.Tdocf", "Usaqttmedida");
            DropColumn("dbo.Tdocf", "Descqttmedida");
            DropColumn("dbo.Tdocf", "Noalteramedida");
            DropColumn("dbo.Tdocf", "Etpemiss");
            DropColumn("dbo.Tdocf", "Etpimpress");
            DropColumn("dbo.Tdocf", "Etpemail");
            DropColumn("dbo.Tdocf", "Etpemisstxt");
            DropColumn("dbo.Tdocf", "Etpimpresstxt");
            DropColumn("dbo.Tdocf", "Etpemailtxt");
            DropColumn("dbo.Tdocf", "Ctrqttorig");
            DropColumn("dbo.Tpgf", "Qmc");
            DropColumn("dbo.Tpgf", "Qmcdathora");
            DropColumn("dbo.Tpgf", "Qma");
            DropColumn("dbo.Tpgf", "Qmadathora");
            DropColumn("dbo.Tpgf", "Etpemiss");
            DropColumn("dbo.Tpgf", "Etpimpress");
            DropColumn("dbo.Tpgf", "Etpemail");
            DropColumn("dbo.Tpgf", "Etpemisstxt");
            DropColumn("dbo.Tpgf", "Etpimpresstxt");
            DropColumn("dbo.Tpgf", "Etpemailtxt");
            DropColumn("dbo.TRcl", "Qmc");
            DropColumn("dbo.TRcl", "Qmcdathora");
            DropColumn("dbo.TRcl", "Qma");
            DropColumn("dbo.TRcl", "Qmadathora");
            DropColumn("dbo.TRcl", "Etpemiss");
            DropColumn("dbo.TRcl", "Etpimpress");
            DropColumn("dbo.TRcl", "Etpemail");
            DropColumn("dbo.TRcl", "Etpemisstxt");
            DropColumn("dbo.TRcl", "Etpimpresstxt");
            DropColumn("dbo.TRcl", "Etpemailtxt");
            DropColumn("dbo.Empresa", "MoedaMT");
            DropColumn("dbo.UsrModulo", "status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UsrModulo", "status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Empresa", "MoedaMT", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Etpemailtxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Etpimpresstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Etpemisstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Etpemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.TRcl", "Etpimpress", c => c.Boolean(nullable: false));
            AddColumn("dbo.TRcl", "Etpemiss", c => c.Boolean(nullable: false));
            AddColumn("dbo.TRcl", "Qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.TRcl", "Qma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.TRcl", "Qmc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tpgf", "Etpemailtxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tpgf", "Etpimpresstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tpgf", "Etpemisstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tpgf", "Etpemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tpgf", "Etpimpress", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tpgf", "Etpemiss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tpgf", "Qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tpgf", "Qma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tpgf", "Qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tpgf", "Qmc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Ctrqttorig", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Etpemailtxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Etpimpresstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Etpemisstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Etpemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Etpimpress", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Etpemiss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Noalteramedida", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Descqttmedida", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Usaqttmedida", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Obrigalote", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Nopergtec", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Usatec", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Expresstitulo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Expressemidoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Maskoprecos", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Maskpreco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Maskqtt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Aprova", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Adjudica", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Dias", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdocf", "Prestacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Usaanexo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Usaemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Campopreco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Descpreco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Titimpress", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Ecran", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "CopiaDocs", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Docfact", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Ndocfact", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdocf", "Facturar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Titulo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Copyvalor", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Copyqtt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Nalteratz", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Movtes", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "CtrlPlaf", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Ctrqttorig", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Etpemailtxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Etpimpresstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Etpemisstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Etpemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Etpimpress", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Etpemiss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Noalteramedida", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Descqttmedida", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Usaqttmedida", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Obrigalote", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Nopergtec", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Usatec", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Maskoprecos", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Maskpreco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Maskqtt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "TesouraPgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdoc", "EmailText", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Subj", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "DestinationEmail", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Usaattach", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Autoemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Expresstitulo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Expressemidoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Usaanexo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Usaemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Campopreco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Descpreco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Titimpress", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Ecran", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Noimp", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Descdoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "CopiaDocs", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "docfact", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "ndocfact", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdoc", "Facturar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Prestacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Copyvalor", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Copyqtt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Copia", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Introdir", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tdoc", "Qma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tdoc", "Qmc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdoc", "Movtes", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Recibo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "CtrlPlaf", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Dotacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Di", "CIFMT", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "CIFMOEDA", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "peso", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "volumes", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "embarque", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "matrTransp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "valmin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Regular", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "gdiversos", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "ocusto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Frete", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Fob", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "nrTransp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Transp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Terminal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Fronteira", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "tservico", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "codproc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "tprocess", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Codlfin", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Codfin", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Codareap", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Codcont", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Turno", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "CodInterno", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Impressodh", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Usrimpress", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Impresso", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dil", "Tipocheck", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Perlinha", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Usaperlinha", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dil", "Grupo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Totalmedida", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Qttmedida", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Lotelimft", c => c.DateTime(nullable: false));
            AddColumn("dbo.Dil", "lotevalid", c => c.DateTime(nullable: false));
            AddColumn("dbo.Dil", "qualidade", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "pagina", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "psobretx", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "piva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "pimpcons", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "pdireire", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "vsobretx", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "viva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "vimpcons", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Vdireire", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Txsobretx", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Tximpcons", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Txdireire", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "docanter", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "anexos", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "licenca", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "cproced", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "opais", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "qttsuplim2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Dil", "qttsuplim1", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Dil", "classe", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "qttvolumes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "tvolume", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "oducifmt", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "cifmt", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "cifme", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "ocusto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "segurome", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "freteme", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "fobme", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "moedaf", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Peso", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Dil", "marcnum", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "nlinha", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "Pack", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "codstat", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Dil", "mpr", c => c.Boolean(nullable: false));
            AddColumn("dbo.Caixa", "qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Caixa", "qma", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.UsrModulo", "Usrstamp", "dbo.Usr");
            DropForeignKey("dbo.UsrAudit", "Usrstamp", "dbo.Usr");
            DropForeignKey("dbo.Reserval", "Reservastamp", "dbo.Reserva");
            DropForeignKey("dbo.ParamImp", "Paramstamp", "dbo.Param");
            DropForeignKey("dbo.EmpresaMod", "Empresastamp", "dbo.Empresa");
            DropForeignKey("dbo.Apivliq", "Apparamstamp", "dbo.Apparam");
            DropForeignKey("dbo.Apivded", "Apparamstamp", "dbo.Apparam");
            DropIndex("dbo.UsrModulo", new[] { "Usrstamp" });
            DropIndex("dbo.UsrAudit", new[] { "Usrstamp" });
            DropIndex("dbo.Reserval", new[] { "Reservastamp" });
            DropIndex("dbo.ParamImp", new[] { "Paramstamp" });
            DropIndex("dbo.EmpresaMod", new[] { "Empresastamp" });
            DropIndex("dbo.Apivliq", new[] { "Apparamstamp" });
            DropIndex("dbo.Apivded", new[] { "Apparamstamp" });
            AlterColumn("dbo.UsrModulo", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Ml", "Ecre", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Ml", "Edeb", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Ml", "Cre", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Ml", "Deb", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Ecrefin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Ecreord", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Ecreana", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Edebfin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Edebord", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Edebana", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Crefin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Creord", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Creana", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Debfin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "debord", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Lcont", "Debana", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Dcli", "factor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgfl", "Mvalorreg", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgfl", "Mvalorpreg", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgfl", "Valorreg", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pgfl", "Valorpreg", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Mtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Mtotaliva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Mdesconto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Msubtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Total", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Totaliva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Desconto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Perdesc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Di", "Subtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Dil", "cambiol", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Factl", "Contatz", c => c.Decimal(nullable: false, precision: 9, scale: 0,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "Default",
                        new AnnotationValues(oldValue: "0", newValue: null)
                    },
                }));
            DropColumn("dbo.Teste", "NumDecimal");
            DropColumn("dbo.Teste", "Descricao2");
            DropColumn("dbo.Param", "Mostranib");
            DropColumn("dbo.Param", "Clpgc");
            DropColumn("dbo.Param", "Fncpgc");
            DropColumn("dbo.Param", "Contmascara");
            DropColumn("dbo.Param", "Usames");
            DropColumn("dbo.Lcont", "Moeda2");
            DropColumn("dbo.Lcont", "Docno");
            DropColumn("dbo.Empresa", "Matricula");
            DropColumn("dbo.Empresa", "Capitalsocial");
            DropColumn("dbo.Empresa", "Moeda");
            DropColumn("dbo.TRcl", "Nomfile");
            DropColumn("dbo.Tpgf", "Nomfile");
            DropColumn("dbo.Tdocf", "Vd");
            DropColumn("dbo.Tdocf", "Ft");
            DropColumn("dbo.Tdocf", "Nd");
            DropColumn("dbo.Tdocf", "Nc");
            DropColumn("dbo.Tdoc", "Mascara");
            DropColumn("dbo.Tdoc", "Usamascara");
            DropColumn("dbo.Tdoc", "Vd");
            DropColumn("dbo.Tdoc", "Ft");
            DropColumn("dbo.Tdoc", "Nd");
            DropColumn("dbo.Tdi", "Encomenda");
            DropColumn("dbo.Tdi", "VisivelPOS");
            DropColumn("dbo.Contas", "Ccusto");
            DropColumn("dbo.Contas", "CodCcu");
            DropColumn("dbo.Contas", "VernaFactura");
            DropColumn("dbo.Contas", "Iban");
            DropColumn("dbo.Contas", "Swift");
            DropColumn("dbo.Rcll", "MvalorPend");
            DropColumn("dbo.Rcll", "ValorPend");
            DropColumn("dbo.Rcll", "Valordoc");
            DropColumn("dbo.RCL", "Moeda2");
            DropColumn("dbo.RCL", "Cambiousd");
            DropColumn("dbo.RCL", "Descmovtz");
            DropColumn("dbo.RCL", "Codmovtz");
            DropColumn("dbo.Pgfl", "Anulado");
            DropColumn("dbo.Pgfl", "Valordoc");
            DropColumn("dbo.Pgfl", "MvalorPend");
            DropColumn("dbo.Pgfl", "ValorPend");
            DropColumn("dbo.Pgf", "Moeda2");
            DropColumn("dbo.Pgf", "Cambiousd");
            DropColumn("dbo.Di", "Reserva");
            DropColumn("dbo.Di", "Encomenda");
            DropColumn("dbo.Dil", "Processado");
            DropColumn("dbo.Caixa", "TotalCaixa");
            DropColumn("dbo.Caixa", "Saida");
            DropColumn("dbo.Caixa", "Entrada");
            DropTable("dbo.UsrAudit");
            DropTable("dbo.Reserval");
            DropTable("dbo.Reserva");
            DropTable("dbo.Pgcsa");
            DropTable("dbo.ParamImp");
            DropTable("dbo.Mescont");
            DropTable("dbo.EmpresaMod");
            DropTable("dbo.Apivliq");
            DropTable("dbo.Apparam");
            DropTable("dbo.Apivded");
        }
    }
}
