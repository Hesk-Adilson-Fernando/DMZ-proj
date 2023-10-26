namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstcontabil : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StDrp",
                c => new
                    {
                        StDrpstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Termino = c.DateTime(nullable: false),
                        ValAquis = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ValResidual = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TaxaDeprec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        VDeprAcumulada = c.Decimal(nullable: false, precision: 9, scale: 0),
                        TipoMov = c.String(nullable: false, maxLength: 80),
                        TotalLiquid = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.StDrpstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.StCt",
                c => new
                    {
                        StCtstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descgrupo = c.String(nullable: false, maxLength: 80),
                        Contacc = c.Boolean(nullable: false),
                        MovIntegra = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StCtstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            AddColumn("dbo.St", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "ValAquis", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "ValResidual", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "VdFiscal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "CodAmotr", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Amotr", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "NaturAct", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "TipoAct", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Tipoartigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StCt", "Ststamp", "dbo.St");
            DropForeignKey("dbo.StDrp", "Ststamp", "dbo.St");
            DropIndex("dbo.StCt", new[] { "Ststamp" });
            DropIndex("dbo.StDrp", new[] { "Ststamp" });
            DropColumn("dbo.St", "Tipoartigo");
            DropColumn("dbo.St", "TipoAct");
            DropColumn("dbo.St", "NaturAct");
            DropColumn("dbo.St", "Amotr");
            DropColumn("dbo.St", "CodAmotr");
            DropColumn("dbo.St", "VdFiscal");
            DropColumn("dbo.St", "ValResidual");
            DropColumn("dbo.St", "ValAquis");
            DropColumn("dbo.St", "Activo");
            DropTable("dbo.StCt");
            DropTable("dbo.StDrp");
        }
    }
}
