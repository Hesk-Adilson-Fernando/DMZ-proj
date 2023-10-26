namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updcladdclcontact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClContact",
                c => new
                    {
                        ClContactstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Funcao = c.String(nullable: false, maxLength: 80),
                        Telefone = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                        Rep = c.Boolean(nullable: false),
                        Cob = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClContactstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            CreateTable(
                "dbo.Paramgct",
                c => new
                    {
                        Paramgctstamp = c.String(nullable: false, maxLength: 80),
                        Paramstamp = c.String(nullable: false, maxLength: 80),
                        Grupo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Mascara = c.String(nullable: false, maxLength: 80),
                        Cl = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Paramgctstamp)
                .ForeignKey("dbo.Param", t => t.Paramstamp, cascadeDelete: true)
                .Index(t => t.Paramstamp);
            
            AddColumn("dbo.Cl", "Pais", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "DeficilCobrar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Plafond", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Vencimento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Generico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Desconto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Percdesconto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Insencao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "MotivoInsencao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Cobrador", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Clivainc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cl", "Codtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cl", "Tesouraria", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Localentregas", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "ContaPgc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "GrupoclPgc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "DescGrupoclPgc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ent", "Cobrador", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "MostraProdutoSemStock", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Excluemascara", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "DiarioMesNum", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "DiarioDiamesnum", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "DiarioAnonum", c => c.Boolean(nullable: false));
            DropColumn("dbo.Param", "Fncpgc");
            DropColumn("dbo.Param", "Clpgc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Param", "Clpgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "Fncpgc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropForeignKey("dbo.Paramgct", "Paramstamp", "dbo.Param");
            DropForeignKey("dbo.ClContact", "Clstamp", "dbo.Cl");
            DropIndex("dbo.Paramgct", new[] { "Paramstamp" });
            DropIndex("dbo.ClContact", new[] { "Clstamp" });
            DropColumn("dbo.Param", "DiarioAnonum");
            DropColumn("dbo.Param", "DiarioDiamesnum");
            DropColumn("dbo.Param", "DiarioMesNum");
            DropColumn("dbo.Param", "Excluemascara");
            DropColumn("dbo.Param", "MostraProdutoSemStock");
            DropColumn("dbo.Ent", "Cobrador");
            DropColumn("dbo.Cl", "DescGrupoclPgc");
            DropColumn("dbo.Cl", "GrupoclPgc");
            DropColumn("dbo.Cl", "ContaPgc");
            DropColumn("dbo.Cl", "Localentregas");
            DropColumn("dbo.Cl", "Tesouraria");
            DropColumn("dbo.Cl", "Codtz");
            DropColumn("dbo.Cl", "Clivainc");
            DropColumn("dbo.Cl", "Cobrador");
            DropColumn("dbo.Cl", "MotivoInsencao");
            DropColumn("dbo.Cl", "Insencao");
            DropColumn("dbo.Cl", "Percdesconto");
            DropColumn("dbo.Cl", "Desconto");
            DropColumn("dbo.Cl", "Generico");
            DropColumn("dbo.Cl", "Vencimento");
            DropColumn("dbo.Cl", "Plafond");
            DropColumn("dbo.Cl", "DeficilCobrar");
            DropColumn("dbo.Cl", "Pais");
            DropTable("dbo.Paramgct");
            DropTable("dbo.ClContact");
        }
    }
}
