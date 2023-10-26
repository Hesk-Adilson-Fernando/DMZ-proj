namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTabelas1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dc",
                c => new
                    {
                        Dcstamp = c.String(nullable: false, maxLength: 80),
                        docno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        docnome = c.String(nullable: false, maxLength: 80),
                        abrv = c.String(nullable: false, maxLength: 80),
                        pedeval = c.Boolean(nullable: false),
                        arredonda = c.Boolean(nullable: false),
                        olcodigo = c.String(nullable: false, maxLength: 80),
                        nvaimapa = c.Boolean(nullable: false),
                        oldesc = c.String(nullable: false, maxLength: 80),
                        lancaol = c.Boolean(nullable: false),
                        naolancapla = c.Boolean(nullable: false),
                        oltrfa = c.Boolean(nullable: false),
                        introol = c.Boolean(nullable: false),
                        ollinhas = c.Boolean(nullable: false),
                        automl = c.Boolean(nullable: false),
                        qmc = c.String(nullable: false, maxLength: 80),
                        qmcdathora = c.DateTime(nullable: false),
                        qma = c.String(nullable: false, maxLength: 80),
                        qmadathora = c.DateTime(nullable: false),
                        apuraiva = c.Boolean(nullable: false),
                        apurares = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Dcstamp);
            
            CreateTable(
                "dbo.Dcli",
                c => new
                    {
                        Dclistamp = c.String(nullable: false, maxLength: 80),
                        dcstamp = c.String(nullable: false, maxLength: 80),
                        conta = c.String(nullable: false, maxLength: 80),
                        rubrica = c.String(nullable: false, maxLength: 80),
                        deb = c.Boolean(nullable: false),
                        valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        factor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        evalor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        lordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        lbanco = c.Boolean(nullable: false),
                        cct = c.String(nullable: false, maxLength: 80),
                        ncusto = c.String(nullable: false, maxLength: 80),
                        oldesc = c.String(nullable: false, maxLength: 80),
                        docno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        sgrupo = c.String(nullable: false, maxLength: 80),
                        grupo = c.String(nullable: false, maxLength: 80),
                        olcodigo = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Dclistamp)
                .ForeignKey("dbo.Dc", t => t.dcstamp, cascadeDelete: true)
                .Index(t => t.dcstamp);
            
            CreateTable(
                "dbo.Diario",
                c => new
                    {
                        Diariostamp = c.String(nullable: false, maxLength: 80),
                        Dino = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        docno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        docnome = c.String(nullable: false, maxLength: 80),
                        dilno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        deb = c.Decimal(nullable: false, precision: 9, scale: 0),
                        cre = c.Decimal(nullable: false, precision: 9, scale: 0),
                        conana = c.Decimal(nullable: false, precision: 9, scale: 0),
                        confin = c.Decimal(nullable: false, precision: 9, scale: 0),
                        conord = c.Decimal(nullable: false, precision: 9, scale: 0),
                        edeb = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ecre = c.Decimal(nullable: false, precision: 9, scale: 0),
                        diano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        qmc = c.String(nullable: false, maxLength: 80),
                        qmcdathora = c.DateTime(nullable: false),
                        qma = c.String(nullable: false, maxLength: 80),
                        qmadathora = c.DateTime(nullable: false),
                        defeito = c.Boolean(nullable: false),
                        apura = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Diariostamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dcli", "dcstamp", "dbo.Dc");
            DropIndex("dbo.Dcli", new[] { "dcstamp" });
            DropTable("dbo.Diario");
            DropTable("dbo.Dcli");
            DropTable("dbo.Dc");
        }
    }
}
