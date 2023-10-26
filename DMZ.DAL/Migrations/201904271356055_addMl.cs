namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lcont",
                c => new
                    {
                        Lcontstamp = c.String(nullable: false, maxLength: 80),
                        Dinome = c.String(maxLength: 80),
                        Dilno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Docnome = c.String(maxLength: 80),
                        Adoc = c.String(maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Mes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dia = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dino = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Doctipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Debana = c.Decimal(nullable: false, precision: 9, scale: 0),
                        debord = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Debfin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Creana = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Creord = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Crefin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Edebana = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Edebord = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Edebfin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ecreana = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ecreord = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ecrefin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Memissao = c.String(maxLength: 80),
                        Ncont = c.String(maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cambio = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Qmc = c.String(maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Lcontstamp);
            
            CreateTable(
                "dbo.Ml",
                c => new
                    {
                        Mlstamp = c.String(nullable: false, maxLength: 80),
                        Dinome = c.String(maxLength: 80),
                        Dilno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Docnome = c.String(maxLength: 80),
                        Adoc = c.String(maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Mes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dia = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Conta = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Rubrica = c.String(maxLength: 80),
                        Deb = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cre = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Edeb = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ecre = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dino = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descritivo = c.String(maxLength: 80),
                        Cct = c.String(maxLength: 80),
                        Debl = c.Boolean(nullable: false),
                        Vemdedc = c.Boolean(nullable: false),
                        Recapit = c.String(maxLength: 80),
                        Ncont = c.String(maxLength: 80),
                        Recapval = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Docno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Doctipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Separa = c.Boolean(nullable: false),
                        Lcontstamp = c.String(maxLength: 80),
                        Vemdoext = c.Boolean(nullable: false),
                        Erecapval = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Lordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Npt = c.String(maxLength: 80),
                        Bastamp = c.String(maxLength: 80),
                        Intid = c.String(maxLength: 80),
                        idorigem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        origem = c.String(maxLength: 80),
                        reco = c.Boolean(nullable: false),
                        extracto = c.String(maxLength: 80),
                        oristamp = c.String(maxLength: 80),
                        olcodigo = c.String(maxLength: 80),
                        sgrupo = c.String(maxLength: 80),
                        grupo = c.String(maxLength: 80),
                        debm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        crem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        pncont = c.String(maxLength: 80),
                        conf1 = c.Boolean(nullable: false),
                        conf2 = c.Boolean(nullable: false),
                        codis = c.String(maxLength: 80),
                        czonag = c.String(maxLength: 80),
                        codisconf = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Chave = c.String(maxLength: 80),
                        numcontrepres = c.String(maxLength: 80),
                        codprovincia = c.String(maxLength: 80),
                        cambio = c.Decimal(nullable: false, precision: 9, scale: 0),
                        paistamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Mlstamp)
                .ForeignKey("dbo.Lcont", t => t.Lcontstamp)
                .Index(t => t.Lcontstamp);
            
            CreateTable(
                "dbo.Pgc",
                c => new
                    {
                        Pgcstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        ncont = c.String(maxLength: 80),
                        integracao = c.Boolean(nullable: false),
                        contaiva = c.String(maxLength: 80),
                        codiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        codiva2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        taxaiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        dbcr = c.String(maxLength: 80),
                        dbdb = c.String(maxLength: 80),
                        crdb = c.String(maxLength: 80),
                        crcr = c.String(maxLength: 80),
                        udata = c.DateTime(nullable: false),
                        multicc = c.Boolean(nullable: false),
                        qualci = c.String(maxLength: 80),
                        obs = c.String(maxLength: 80),
                        recapit = c.String(maxLength: 80),
                        local = c.String(maxLength: 80),
                        contado = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ollocal = c.String(maxLength: 80),
                        lancaol = c.Boolean(nullable: false),
                        servcee = c.Boolean(nullable: false),
                        obrigacc = c.Boolean(nullable: false),
                        obrigaol = c.Boolean(nullable: false),
                        ppconta = c.String(maxLength: 80),
                        ppdesc = c.String(maxLength: 80),
                        obriganc = c.Boolean(nullable: false),
                        ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        olmoeda = c.String(maxLength: 80),
                        doabrebe = c.Boolean(nullable: false),
                        codis = c.String(maxLength: 80),
                        pme = c.Boolean(nullable: false),
                        criadanoano = c.Boolean(nullable: false),
                        marcada = c.Boolean(nullable: false),
                        qmc = c.String(maxLength: 80),
                        qmcdathora = c.DateTime(nullable: false),
                        qma = c.String(maxLength: 80),
                        qmadathora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Pgcstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ml", "Lcontstamp", "dbo.Lcont");
            DropIndex("dbo.Ml", new[] { "Lcontstamp" });
            DropTable("dbo.Pgc");
            DropTable("dbo.Ml");
            DropTable("dbo.Lcont");
        }
    }
}
