namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRH : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Peacidente",
                c => new
                    {
                        Peacidentestamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        TipoAcidente = c.String(nullable: false, maxLength: 80),
                        LocalAcidente = c.String(nullable: false, maxLength: 80),
                        Hospitalizacao = c.Boolean(nullable: false),
                        Mortal = c.Boolean(nullable: false),
                        Incapacidade = c.String(nullable: false, maxLength: 80),
                        Ausencia = c.String(nullable: false, maxLength: 80),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Peacidentestamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            AddColumn("dbo.Desconto", "Obs", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Codccu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CCusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "HorasSemana", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "SalHora", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "TabIrps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodRepFinancas", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "DescRepFinancas", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Sub", "Obs", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Sub", "PagoMesFerias", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sub", "PagoSubsFerias", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sub", "PagoSubsNatal", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sub", "PagoExtra", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sub", "Moeda", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Peacidente", "Pestamp", "dbo.Pe");
            DropIndex("dbo.Peacidente", new[] { "Pestamp" });
            DropColumn("dbo.Sub", "Moeda");
            DropColumn("dbo.Sub", "PagoExtra");
            DropColumn("dbo.Sub", "PagoSubsNatal");
            DropColumn("dbo.Sub", "PagoSubsFerias");
            DropColumn("dbo.Sub", "PagoMesFerias");
            DropColumn("dbo.Sub", "Obs");
            DropColumn("dbo.Pe", "DescRepFinancas");
            DropColumn("dbo.Pe", "CodRepFinancas");
            DropColumn("dbo.Pe", "TabIrps");
            DropColumn("dbo.Pe", "SalHora");
            DropColumn("dbo.Pe", "HorasSemana");
            DropColumn("dbo.Pe", "CCusto");
            DropColumn("dbo.Pe", "Codccu");
            DropColumn("dbo.Desconto", "Obs");
            DropTable("dbo.Peacidente");
        }
    }
}
