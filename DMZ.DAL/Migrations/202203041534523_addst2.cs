namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addst2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Motoristal", "Motoristastamp", "dbo.Motorista");
            DropForeignKey("dbo.StDrp", "Ststamp", "dbo.St");
            DropIndex("dbo.Motoristal", new[] { "Motoristastamp" });
            CreateTable(
                "dbo.Condpag",
                c => new
                    {
                        Condpagstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Cliente = c.Boolean(nullable: false),
                        Forn = c.Boolean(nullable: false),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Condpagstamp);
            
            CreateTable(
                "dbo.Condpagl",
                c => new
                    {
                        Condpaglstamp = c.String(nullable: false, maxLength: 80),
                        Condpagstamp = c.String(nullable: false, maxLength: 80),
                        Diain = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diafim = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Percetagem = c.Decimal(nullable: false, precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.Condpaglstamp)
                .ForeignKey("dbo.Condpag", t => t.Condpagstamp, cascadeDelete: true)
                .Index(t => t.Condpagstamp);
            
            CreateTable(
                "dbo.St2",
                c => new
                    {
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Datain = c.DateTime(nullable: false),
                        Localizacao = c.String(nullable: false, maxLength: 80),
                        Nrelement = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nranos = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Vidafis = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Anomvalia = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Reinsvest = c.Boolean(nullable: false),
                        Ndep = c.Boolean(nullable: false),
                        Quotas = c.Boolean(nullable: false),
                        Duodessimos = c.Boolean(nullable: false),
                        Usado = c.Boolean(nullable: false),
                        Repactivo = c.Boolean(nullable: false),
                        Activorep = c.String(nullable: false, maxLength: 80),
                        ValAquis = c.Decimal(nullable: false, precision: 20, scale: 2),
                        ValAquisact = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Quantdep = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Quantrec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Perdas = c.Decimal(nullable: false, precision: 20, scale: 2),
                        ValResidual = c.Decimal(nullable: false, precision: 20, scale: 2),
                        ValFiscal = c.Decimal(nullable: false, precision: 20, scale: 2),
                        CodAmotr = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Amotr = c.String(nullable: false, maxLength: 80),
                        NaturAct = c.String(nullable: false, maxLength: 80),
                        Codtipoact = c.String(nullable: false, maxLength: 80),
                        Tipoact = c.String(nullable: false, maxLength: 80),
                        Tipoartigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Deptotalnact = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Deptotalact = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valquantesc = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Percdep = c.Decimal(nullable: false, precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.Ststamp)
                .ForeignKey("dbo.St", t => t.Ststamp)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.TabelaAmort",
                c => new
                    {
                        TabelaAmortstamp = c.String(nullable: false, maxLength: 80),
                        Divisao = c.String(nullable: false, maxLength: 5),
                        Tipo = c.String(nullable: false, maxLength: 5),
                        Codigo = c.String(nullable: false, maxLength: 10),
                        Diploma = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Perc1 = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Vidamax = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Perc2 = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Desc2 = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.TabelaAmortstamp);
            
            AddColumn("dbo.Cc", "Descontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Cc", "MDescontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Fact", "Perdescfin", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.Fact", "Descontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Fact", "MDescontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Fact", "CodCondPagamento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fact", "DescCondPagamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Descontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Facc", "MDescontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Facc", "Perdescfin", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.Facc", "CodCondPagamento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "DescCondPagamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgf", "Descontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pgf", "MDescontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pgf", "Perdescfin", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.Pgfl", "Descontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pgfl", "MDescontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pgfl", "Perdescfin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.RCL", "Descontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.RCL", "MDescontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.RCL", "Perdescfin", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.Rcll", "Descontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Rcll", "MDescontofin", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Rcll", "Perdescfin", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.Cl", "CodCondPagamento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "DescCondPagamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fnc", "CodCondPagamento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fnc", "DescCondPagamento", c => c.String(nullable: false, maxLength: 80));
            AddForeignKey("dbo.StDrp", "Ststamp", "dbo.St2", "Ststamp", cascadeDelete: true);
            DropColumn("dbo.St", "ValAquis");
            DropColumn("dbo.St", "ValResidual");
            DropColumn("dbo.St", "VdFiscal");
            DropColumn("dbo.St", "CodAmotr");
            DropColumn("dbo.St", "Amotr");
            DropColumn("dbo.St", "NaturAct");
            DropColumn("dbo.St", "TipoAct");
            DropTable("dbo.Motorista");
            DropTable("dbo.Motoristal");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Motoristal",
                c => new
                    {
                        Motoristalstamp = c.String(nullable: false, maxLength: 80),
                        Motoristastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Motoristalstamp);
            
            CreateTable(
                "dbo.Motorista",
                c => new
                    {
                        Motoristastamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Motoristastamp);
            
            AddColumn("dbo.St", "TipoAct", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "NaturAct", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Amotr", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "CodAmotr", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "VdFiscal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "ValResidual", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "ValAquis", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropForeignKey("dbo.St2", "Ststamp", "dbo.St");
            DropForeignKey("dbo.StDrp", "Ststamp", "dbo.St2");
            DropForeignKey("dbo.Condpagl", "Condpagstamp", "dbo.Condpag");
            DropIndex("dbo.St2", new[] { "Ststamp" });
            DropIndex("dbo.Condpagl", new[] { "Condpagstamp" });
            DropColumn("dbo.Fnc", "DescCondPagamento");
            DropColumn("dbo.Fnc", "CodCondPagamento");
            DropColumn("dbo.Cl", "DescCondPagamento");
            DropColumn("dbo.Cl", "CodCondPagamento");
            DropColumn("dbo.Rcll", "Perdescfin");
            DropColumn("dbo.Rcll", "MDescontofin");
            DropColumn("dbo.Rcll", "Descontofin");
            DropColumn("dbo.RCL", "Perdescfin");
            DropColumn("dbo.RCL", "MDescontofin");
            DropColumn("dbo.RCL", "Descontofin");
            DropColumn("dbo.Pgfl", "Perdescfin");
            DropColumn("dbo.Pgfl", "MDescontofin");
            DropColumn("dbo.Pgfl", "Descontofin");
            DropColumn("dbo.Pgf", "Perdescfin");
            DropColumn("dbo.Pgf", "MDescontofin");
            DropColumn("dbo.Pgf", "Descontofin");
            DropColumn("dbo.Facc", "DescCondPagamento");
            DropColumn("dbo.Facc", "CodCondPagamento");
            DropColumn("dbo.Facc", "Perdescfin");
            DropColumn("dbo.Facc", "MDescontofin");
            DropColumn("dbo.Facc", "Descontofin");
            DropColumn("dbo.Fact", "DescCondPagamento");
            DropColumn("dbo.Fact", "CodCondPagamento");
            DropColumn("dbo.Fact", "MDescontofin");
            DropColumn("dbo.Fact", "Descontofin");
            DropColumn("dbo.Fact", "Perdescfin");
            DropColumn("dbo.Cc", "MDescontofin");
            DropColumn("dbo.Cc", "Descontofin");
            DropTable("dbo.TabelaAmort");
            DropTable("dbo.St2");
            DropTable("dbo.Condpagl");
            DropTable("dbo.Condpag");
            CreateIndex("dbo.Motoristal", "Motoristastamp");
            AddForeignKey("dbo.StDrp", "Ststamp", "dbo.St", "Ststamp", cascadeDelete: true);
            AddForeignKey("dbo.Motoristal", "Motoristastamp", "dbo.Motorista", "Motoristastamp", cascadeDelete: true);
        }
    }
}
