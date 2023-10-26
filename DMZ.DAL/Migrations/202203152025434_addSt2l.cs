namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSt2l : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dlei",
                c => new
                    {
                        Dleistamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 2000),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Depmapa = c.String(nullable: false, maxLength: 80),
                        Reavmapa = c.String(nullable: false, maxLength: 80),
                        Perc = c.Decimal(nullable: false, precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.Dleistamp);
            
            CreateTable(
                "dbo.Dleil",
                c => new
                    {
                        Dleilstamp = c.String(nullable: false, maxLength: 80),
                        Dleistamp = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Coef = c.Decimal(nullable: false, precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.Dleilstamp);
            
            CreateTable(
                "dbo.StDrpc",
                c => new
                    {
                        Stdrpcstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Datac = c.DateTime(nullable: false),
                        Valdep = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valdepact = c.Decimal(nullable: false, precision: 20, scale: 2),
                        TaxaDeprec = c.Decimal(nullable: false, precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.Stdrpcstamp)
                .ForeignKey("dbo.St2", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.Stimpar",
                c => new
                    {
                        Stimparstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Referencia = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Valdep = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Depreciacao = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valescriturada = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valrecup = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valimparidade = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valacuimp = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valacurevers = c.Decimal(nullable: false, precision: 20, scale: 2),
                    })
                .PrimaryKey(t => t.Stimparstamp)
                .ForeignKey("dbo.St2", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.Streaval",
                c => new
                    {
                        Streavalstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Decreto = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Aquis = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Aquisreaval = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Dep = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Depcorrig = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Contab = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Streavalstamp)
                .ForeignKey("dbo.St2", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.Streval",
                c => new
                    {
                        Strevalstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Referencia = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Valdep = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Depreciacao = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valescriturada = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valrecup = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valimparidade = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valacuimp = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Valacurevers = c.Decimal(nullable: false, precision: 20, scale: 2),
                    })
                .PrimaryKey(t => t.Strevalstamp)
                .ForeignKey("dbo.St2", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            AddColumn("dbo.St2", "Vdreal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St2", "Valavaliac", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St2", "Datavaliac", c => c.DateTime(nullable: false));
            AddColumn("dbo.St2", "Duracao", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St2", "Datafim", c => c.DateTime(nullable: false));
            AddColumn("dbo.St2", "Databate", c => c.DateTime(nullable: false));
            AddColumn("dbo.St2", "Valvenda", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St2", "Motivo", c => c.String(nullable: false));
            AddColumn("dbo.StDrp", "Data", c => c.DateTime(nullable: false));
            AddColumn("dbo.StDrp", "Valdepact", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.StDrp", "Valdep", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.StDrp", "Valdepnact", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.StDrp", "TaxaDeprec", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            DropColumn("dbo.StDrp", "Termino");
            DropColumn("dbo.StDrp", "ValAquis");
            DropColumn("dbo.StDrp", "ValResidual");
            DropColumn("dbo.StDrp", "VDeprAcumulada");
            DropColumn("dbo.StDrp", "TipoMov");
            DropColumn("dbo.StDrp", "TotalLiquid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StDrp", "TotalLiquid", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.StDrp", "TipoMov", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.StDrp", "VDeprAcumulada", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.StDrp", "ValResidual", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.StDrp", "ValAquis", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.StDrp", "Termino", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Streval", "Ststamp", "dbo.St2");
            DropForeignKey("dbo.Streaval", "Ststamp", "dbo.St2");
            DropForeignKey("dbo.Stimpar", "Ststamp", "dbo.St2");
            DropForeignKey("dbo.StDrpc", "Ststamp", "dbo.St2");
            DropIndex("dbo.Streval", new[] { "Ststamp" });
            DropIndex("dbo.Streaval", new[] { "Ststamp" });
            DropIndex("dbo.Stimpar", new[] { "Ststamp" });
            DropIndex("dbo.StDrpc", new[] { "Ststamp" });
            AlterColumn("dbo.StDrp", "TaxaDeprec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.StDrp", "Valdepnact");
            DropColumn("dbo.StDrp", "Valdep");
            DropColumn("dbo.StDrp", "Valdepact");
            DropColumn("dbo.StDrp", "Data");
            DropColumn("dbo.St2", "Motivo");
            DropColumn("dbo.St2", "Valvenda");
            DropColumn("dbo.St2", "Databate");
            DropColumn("dbo.St2", "Datafim");
            DropColumn("dbo.St2", "Duracao");
            DropColumn("dbo.St2", "Datavaliac");
            DropColumn("dbo.St2", "Valavaliac");
            DropColumn("dbo.St2", "Vdreal");
            DropTable("dbo.Streval");
            DropTable("dbo.Streaval");
            DropTable("dbo.Stimpar");
            DropTable("dbo.StDrpc");
            DropTable("dbo.Dleil");
            DropTable("dbo.Dlei");
        }
    }
}
