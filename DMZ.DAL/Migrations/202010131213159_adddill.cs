namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dill",
                c => new
                    {
                        Dillstamp = c.String(nullable: false, maxLength: 80),
                        Dilstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Ref = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Unidade = c.String(nullable: false, maxLength: 80),
                        Armazem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Armazem2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mpreco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Lote = c.String(nullable: false, maxLength: 80),
                        Tabiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Txiva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valival = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mvalival = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Ivainc = c.Boolean(nullable: false),
                        Perdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descontol = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mdescontol = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Subtotall = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Msubtotall = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Totall = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Mtotall = c.Decimal(nullable: false, precision: 16, scale: 2),
                        ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        cambiol = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Descarm = c.String(nullable: false, maxLength: 80),
                        Servico = c.Boolean(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Dillstamp)
                .ForeignKey("dbo.Dil", t => t.Dilstamp, cascadeDelete: true)
                .Index(t => t.Dilstamp);
            
            AddColumn("dbo.Di", "Matricula", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Localpartida", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Horapartida", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Horachegada", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Dtpartida", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Dtchegada", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Localmanutencao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Tmanutencao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Dtentrada", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Dtsaida", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Tipocombustivel", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Funcao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Dias", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Salliquido", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Kilometragem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "ValorMulta", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdi", "Folhaobra", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Rcombustivel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Folhatrabalho", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Guiacarga", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Sinistros", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Multas", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Valbase", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dill", "Dilstamp", "dbo.Dil");
            DropIndex("dbo.Dill", new[] { "Dilstamp" });
            DropColumn("dbo.Pe", "Valbase");
            DropColumn("dbo.Tdi", "Multas");
            DropColumn("dbo.Tdi", "Sinistros");
            DropColumn("dbo.Tdi", "Guiacarga");
            DropColumn("dbo.Tdi", "Folhatrabalho");
            DropColumn("dbo.Tdi", "Rcombustivel");
            DropColumn("dbo.Tdi", "Folhaobra");
            DropColumn("dbo.Di", "ValorMulta");
            DropColumn("dbo.Di", "Descricao");
            DropColumn("dbo.Di", "Kilometragem");
            DropColumn("dbo.Di", "Salliquido");
            DropColumn("dbo.Di", "Dias");
            DropColumn("dbo.Di", "Funcao");
            DropColumn("dbo.Di", "Tipocombustivel");
            DropColumn("dbo.Di", "Dtsaida");
            DropColumn("dbo.Di", "Dtentrada");
            DropColumn("dbo.Di", "Tmanutencao");
            DropColumn("dbo.Di", "Localmanutencao");
            DropColumn("dbo.Di", "Dtchegada");
            DropColumn("dbo.Di", "Dtpartida");
            DropColumn("dbo.Di", "Horachegada");
            DropColumn("dbo.Di", "Horapartida");
            DropColumn("dbo.Di", "Localpartida");
            DropColumn("dbo.Di", "Matricula");
            DropTable("dbo.Dill");
        }
    }
}
