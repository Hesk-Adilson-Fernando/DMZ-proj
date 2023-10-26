namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pjvt",
                c => new
                    {
                        Pjvtstamp = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Capacit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nviagens = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totqtt = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                        Marca = c.String(nullable: false, maxLength: 80),
                        Tipo = c.String(nullable: false, maxLength: 80),
                        Valorbase = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Pjvtstamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
            CreateTable(
                "dbo.Vt",
                c => new
                    {
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Marca = c.String(nullable: false, maxLength: 80),
                        Modelo = c.String(nullable: false, maxLength: 80),
                        Motor = c.String(nullable: false, maxLength: 80),
                        Chassis = c.String(nullable: false, maxLength: 80),
                        anofab = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tara = c.Decimal(nullable: false, precision: 9, scale: 0),
                        pesobruto = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Combustivel = c.String(nullable: false, maxLength: 80),
                        Pneus = c.String(nullable: false, maxLength: 80),
                        codentida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nomentida = c.String(nullable: false, maxLength: 80),
                        valInspec = c.DateTime(nullable: false),
                        daquisic = c.DateTime(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Status = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descstatus = c.String(nullable: false, maxLength: 80),
                        Seguradora = c.String(nullable: false, maxLength: 80),
                        Apolice = c.String(nullable: false, maxLength: 80),
                        valapolice = c.DateTime(nullable: false),
                        codtrl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        trailer = c.String(nullable: false, maxLength: 80),
                        Numlic = c.String(nullable: false, maxLength: 80),
                        DatLic = c.DateTime(nullable: false),
                        validLic = c.DateTime(nullable: false),
                        NumInspec = c.String(nullable: false, maxLength: 80),
                        DatInspec = c.DateTime(nullable: false),
                        DatSegura = c.DateTime(nullable: false),
                        Anomanifest = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Datmanifest = c.DateTime(nullable: false),
                        Validmanifest = c.DateTime(nullable: false),
                        capacit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Externa = c.Boolean(nullable: false),
                        numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        medveloc = c.String(nullable: false, maxLength: 80),
                        qttporkm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        capaclitros = c.Decimal(nullable: false, precision: 9, scale: 0),
                        _ref = c.String(name: "ref", nullable: false, maxLength: 80),
                        stdesc = c.String(nullable: false, maxLength: 80),
                        codmarca = c.Decimal(nullable: false, precision: 9, scale: 0),
                        tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        designacao = c.String(nullable: false, maxLength: 80),
                        valorbase = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Vtstamp);
            
            CreateTable(
                "dbo.Vtcfg",
                c => new
                    {
                        Vtcfgstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        Feito = c.Boolean(nullable: false),
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                        Distamp = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Valor2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Vtcfgstamp)
                .ForeignKey("dbo.Vt", t => t.Vtstamp, cascadeDelete: true)
                .Index(t => t.Vtstamp);
            
            CreateTable(
                "dbo.Vtcorreias",
                c => new
                    {
                        Vtcorreiasstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Reforig = c.String(nullable: false, maxLength: 80),
                        Outraref1 = c.String(nullable: false, maxLength: 80),
                        Outraref2 = c.String(nullable: false, maxLength: 80),
                        Outraref3 = c.String(nullable: false, maxLength: 80),
                        Outraref4 = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Vtcorreiasstamp)
                .ForeignKey("dbo.Vt", t => t.Vtstamp, cascadeDelete: true)
                .Index(t => t.Vtstamp);
            
            CreateTable(
                "dbo.Vtdoc",
                c => new
                    {
                        Vtdocstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.String(nullable: false, maxLength: 80),
                        Tipodoc = c.String(nullable: false, maxLength: 80),
                        Entidade = c.String(nullable: false, maxLength: 80),
                        Datain = c.DateTime(nullable: false),
                        Datatermino = c.DateTime(nullable: false),
                        Anexo = c.Binary(),
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Vtdocstamp)
                .ForeignKey("dbo.Vt", t => t.Vtstamp, cascadeDelete: true)
                .Index(t => t.Vtstamp);
            
            CreateTable(
                "dbo.Vtfiltros",
                c => new
                    {
                        Vtfiltrosstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Reforig = c.String(nullable: false, maxLength: 80),
                        Outraref1 = c.String(nullable: false, maxLength: 80),
                        Outraref2 = c.String(nullable: false, maxLength: 80),
                        Outraref3 = c.String(nullable: false, maxLength: 80),
                        Outraref4 = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Vtfiltrosstamp)
                .ForeignKey("dbo.Vt", t => t.Vtstamp, cascadeDelete: true)
                .Index(t => t.Vtstamp);
            
            CreateTable(
                "dbo.Vtman",
                c => new
                    {
                        Vtmanstamp = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Valparam = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valkm = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diferenca = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Feito = c.Boolean(nullable: false),
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                        Distamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Vtmanstamp)
                .ForeignKey("dbo.Vt", t => t.Vtstamp, cascadeDelete: true)
                .Index(t => t.Vtstamp);
            
            CreateTable(
                "dbo.Vtoleos",
                c => new
                    {
                        Vtoleosstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Reforig = c.String(nullable: false, maxLength: 80),
                        Outraref1 = c.String(nullable: false, maxLength: 80),
                        Outraref2 = c.String(nullable: false, maxLength: 80),
                        Outraref3 = c.String(nullable: false, maxLength: 80),
                        Outraref4 = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Vtoleosstamp)
                .ForeignKey("dbo.Vt", t => t.Vtstamp, cascadeDelete: true)
                .Index(t => t.Vtstamp);
            
            CreateTable(
                "dbo.Vtpneus",
                c => new
                    {
                        Vtpneusstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dataent = c.DateTime(nullable: false),
                        Datasaida = c.DateTime(nullable: false),
                        Posicao = c.String(nullable: false, maxLength: 80),
                        Vtstamp = c.String(nullable: false, maxLength: 80),
                        Distamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Vtpneusstamp)
                .ForeignKey("dbo.Vt", t => t.Vtstamp, cascadeDelete: true)
                .Index(t => t.Vtstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vtpneus", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtoleos", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtman", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtfiltros", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtdoc", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtcorreias", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtcfg", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Pjvt", "Pjstamp", "dbo.Pj");
            DropIndex("dbo.Vtpneus", new[] { "Vtstamp" });
            DropIndex("dbo.Vtoleos", new[] { "Vtstamp" });
            DropIndex("dbo.Vtman", new[] { "Vtstamp" });
            DropIndex("dbo.Vtfiltros", new[] { "Vtstamp" });
            DropIndex("dbo.Vtdoc", new[] { "Vtstamp" });
            DropIndex("dbo.Vtcorreias", new[] { "Vtstamp" });
            DropIndex("dbo.Vtcfg", new[] { "Vtstamp" });
            DropIndex("dbo.Pjvt", new[] { "Pjstamp" });
            DropTable("dbo.Vtpneus");
            DropTable("dbo.Vtoleos");
            DropTable("dbo.Vtman");
            DropTable("dbo.Vtfiltros");
            DropTable("dbo.Vtdoc");
            DropTable("dbo.Vtcorreias");
            DropTable("dbo.Vtcfg");
            DropTable("dbo.Vt");
            DropTable("dbo.Pjvt");
        }
    }
}
