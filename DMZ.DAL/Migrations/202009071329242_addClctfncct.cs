namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addClctfncct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClCt",
                c => new
                    {
                        ClCtstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descgrupo = c.String(nullable: false, maxLength: 80),
                        Contacc = c.Boolean(nullable: false),
                        MovIntegra = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClCtstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            CreateTable(
                "dbo.FncContact",
                c => new
                    {
                        FncContactstamp = c.String(nullable: false, maxLength: 80),
                        Fncstamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Funcao = c.String(nullable: false, maxLength: 80),
                        Telefone = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                        Rep = c.Boolean(nullable: false),
                        Cob = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FncContactstamp)
                .ForeignKey("dbo.Fnc", t => t.Fncstamp, cascadeDelete: true)
                .Index(t => t.Fncstamp);
            
            CreateTable(
                "dbo.FncCt",
                c => new
                    {
                        FncCtstamp = c.String(nullable: false, maxLength: 80),
                        Fncstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descgrupo = c.String(nullable: false, maxLength: 80),
                        Contacc = c.Boolean(nullable: false),
                        MovIntegra = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FncCtstamp)
                .ForeignKey("dbo.Fnc", t => t.Fncstamp, cascadeDelete: true)
                .Index(t => t.Fncstamp);
            
            AddColumn("dbo.Cl", "Site", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fnc", "Localidade", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fnc", "Site", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fnc", "Plafond", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fnc", "Vencimento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fnc", "Desconto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fnc", "Percdesconto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fnc", "Insencao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fnc", "MotivoInsencao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fnc", "Clivainc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fnc", "Codtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Fnc", "Tesouraria", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fnc", "Localentregas", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "CriaContascl", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "CriaContasfnc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FncCt", "Fncstamp", "dbo.Fnc");
            DropForeignKey("dbo.FncContact", "Fncstamp", "dbo.Fnc");
            DropForeignKey("dbo.ClCt", "Clstamp", "dbo.Cl");
            DropIndex("dbo.FncCt", new[] { "Fncstamp" });
            DropIndex("dbo.FncContact", new[] { "Fncstamp" });
            DropIndex("dbo.ClCt", new[] { "Clstamp" });
            DropColumn("dbo.Param", "CriaContasfnc");
            DropColumn("dbo.Param", "CriaContascl");
            DropColumn("dbo.Fnc", "Localentregas");
            DropColumn("dbo.Fnc", "Tesouraria");
            DropColumn("dbo.Fnc", "Codtz");
            DropColumn("dbo.Fnc", "Clivainc");
            DropColumn("dbo.Fnc", "MotivoInsencao");
            DropColumn("dbo.Fnc", "Insencao");
            DropColumn("dbo.Fnc", "Percdesconto");
            DropColumn("dbo.Fnc", "Desconto");
            DropColumn("dbo.Fnc", "Vencimento");
            DropColumn("dbo.Fnc", "Plafond");
            DropColumn("dbo.Fnc", "Site");
            DropColumn("dbo.Fnc", "Localidade");
            DropColumn("dbo.Cl", "Site");
            DropTable("dbo.FncCt");
            DropTable("dbo.FncContact");
            DropTable("dbo.ClCt");
        }
    }
}
