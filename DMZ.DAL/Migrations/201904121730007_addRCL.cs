namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRCL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RCL",
                c => new
                    {
                        Rclstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(maxLength: 80),
                        Moeda = c.String(maxLength: 80),
                        Banco = c.String(maxLength: 80),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mtotal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(maxLength: 80),
                        Process = c.Boolean(nullable: false),
                        Dprocess = c.DateTime(nullable: false),
                        Anulado = c.Boolean(nullable: false),
                        Ccusto = c.String(maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(maxLength: 80),
                        Nomedoc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovcc = c.String(maxLength: 80),
                        Nomecomerc = c.String(maxLength: 80),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(maxLength: 80),
                        Estabno = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estabnome = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Rclstamp);
            
            CreateTable(
                "dbo.RCLL",
                c => new
                    {
                        Rcllstamp = c.String(nullable: false, maxLength: 80),
                        Rclstamp = c.String(maxLength: 80),
                        Ccstamp = c.String(maxLength: 80),
                        data = c.DateTime(nullable: false),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        descricao = c.String(maxLength: 80),
                        Valorpreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valorreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        status = c.Boolean(nullable: false),
                        Numinterno = c.String(maxLength: 80),
                        Origem = c.String(maxLength: 80),
                        Mvalorpreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mvalorreg = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Rcllstamp)
                .ForeignKey("dbo.RCL", t => t.Rclstamp)
                .Index(t => t.Rclstamp);
            
            CreateIndex("dbo.Cc", "rclstamp");
            CreateIndex("dbo.Formasp", "Rclstamp");
            AddForeignKey("dbo.Cc", "rclstamp", "dbo.RCL", "Rclstamp");
            AddForeignKey("dbo.Formasp", "Rclstamp", "dbo.RCL", "Rclstamp");
            DropColumn("dbo.Cc", "qmc");
            DropColumn("dbo.Cc", "qmcdathora");
            DropColumn("dbo.Cc", "qma");
            DropColumn("dbo.Cc", "qmadathora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cc", "qmadathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cc", "qma", c => c.String(maxLength: 80));
            AddColumn("dbo.Cc", "qmcdathora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cc", "qmc", c => c.String(maxLength: 80));
            DropForeignKey("dbo.RCLL", "Rclstamp", "dbo.RCL");
            DropForeignKey("dbo.Formasp", "Rclstamp", "dbo.RCL");
            DropForeignKey("dbo.Cc", "rclstamp", "dbo.RCL");
            DropIndex("dbo.RCLL", new[] { "Rclstamp" });
            DropIndex("dbo.Formasp", new[] { "Rclstamp" });
            DropIndex("dbo.Cc", new[] { "rclstamp" });
            DropTable("dbo.RCLL");
            DropTable("dbo.RCL");
        }
    }
}
