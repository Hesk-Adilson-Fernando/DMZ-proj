namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updst1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vtcfg", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtcorreias", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtdoc", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtfiltros", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtman", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtoleos", "Vtstamp", "dbo.Vt");
            DropForeignKey("dbo.Vtpneus", "Vtstamp", "dbo.Vt");
            DropIndex("dbo.Vtcfg", new[] { "Vtstamp" });
            DropIndex("dbo.Vtcorreias", new[] { "Vtstamp" });
            DropIndex("dbo.Vtdoc", new[] { "Vtstamp" });
            DropIndex("dbo.Vtfiltros", new[] { "Vtstamp" });
            DropIndex("dbo.Vtman", new[] { "Vtstamp" });
            DropIndex("dbo.Vtoleos", new[] { "Vtstamp" });
            DropIndex("dbo.Vtpneus", new[] { "Vtstamp" });
            CreateTable(
                "dbo.Empresadep",
                c => new
                    {
                        Empresadepstamp = c.String(nullable: false, maxLength: 80),
                        Empresastamp = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Empresadepstamp)
                .ForeignKey("dbo.Empresa", t => t.Empresastamp, cascadeDelete: true)
                .Index(t => t.Empresastamp);
            
            AddColumn("dbo.St", "Motorista", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Departanto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Cilindrada", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.St", "Companhia", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Contrato", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Inicio", c => c.DateTime(nullable: false));
            AddColumn("dbo.St", "Termino", c => c.DateTime(nullable: false));
            AddColumn("dbo.St", "ValorLeasing", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St", "Mensalidade", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.St", "Assentos", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Portas", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Data", c => c.DateTime(nullable: false));
            AddColumn("dbo.StVtdoc", "Premio", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.StVtdoc", "Franquia", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropTable("dbo.Vt");
            DropTable("dbo.Vtcfg");
            DropTable("dbo.Vtcorreias");
            DropTable("dbo.Vtdoc");
            DropTable("dbo.Vtfiltros");
            DropTable("dbo.Vtman");
            DropTable("dbo.Vtoleos");
            DropTable("dbo.Vtpneus");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Vtpneusstamp);
            
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
                .PrimaryKey(t => t.Vtoleosstamp);
            
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
                .PrimaryKey(t => t.Vtmanstamp);
            
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
                .PrimaryKey(t => t.Vtfiltrosstamp);
            
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
                .PrimaryKey(t => t.Vtdocstamp);
            
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
                .PrimaryKey(t => t.Vtcorreiasstamp);
            
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
                .PrimaryKey(t => t.Vtcfgstamp);
            
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
            
            DropForeignKey("dbo.Empresadep", "Empresastamp", "dbo.Empresa");
            DropIndex("dbo.Empresadep", new[] { "Empresastamp" });
            DropColumn("dbo.StVtdoc", "Franquia");
            DropColumn("dbo.StVtdoc", "Premio");
            DropColumn("dbo.St", "Data");
            DropColumn("dbo.St", "Portas");
            DropColumn("dbo.St", "Assentos");
            DropColumn("dbo.St", "Mensalidade");
            DropColumn("dbo.St", "ValorLeasing");
            DropColumn("dbo.St", "Termino");
            DropColumn("dbo.St", "Inicio");
            DropColumn("dbo.St", "Contrato");
            DropColumn("dbo.St", "Companhia");
            DropColumn("dbo.St", "Cilindrada");
            DropColumn("dbo.St", "Ccusto");
            DropColumn("dbo.St", "Departanto");
            DropColumn("dbo.St", "Motorista");
            DropTable("dbo.Empresadep");
            CreateIndex("dbo.Vtpneus", "Vtstamp");
            CreateIndex("dbo.Vtoleos", "Vtstamp");
            CreateIndex("dbo.Vtman", "Vtstamp");
            CreateIndex("dbo.Vtfiltros", "Vtstamp");
            CreateIndex("dbo.Vtdoc", "Vtstamp");
            CreateIndex("dbo.Vtcorreias", "Vtstamp");
            CreateIndex("dbo.Vtcfg", "Vtstamp");
            AddForeignKey("dbo.Vtpneus", "Vtstamp", "dbo.Vt", "Vtstamp", cascadeDelete: true);
            AddForeignKey("dbo.Vtoleos", "Vtstamp", "dbo.Vt", "Vtstamp", cascadeDelete: true);
            AddForeignKey("dbo.Vtman", "Vtstamp", "dbo.Vt", "Vtstamp", cascadeDelete: true);
            AddForeignKey("dbo.Vtfiltros", "Vtstamp", "dbo.Vt", "Vtstamp", cascadeDelete: true);
            AddForeignKey("dbo.Vtdoc", "Vtstamp", "dbo.Vt", "Vtstamp", cascadeDelete: true);
            AddForeignKey("dbo.Vtcorreias", "Vtstamp", "dbo.Vt", "Vtstamp", cascadeDelete: true);
            AddForeignKey("dbo.Vtcfg", "Vtstamp", "dbo.Vt", "Vtstamp", cascadeDelete: true);
        }
    }
}
