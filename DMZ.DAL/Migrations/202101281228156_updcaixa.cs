namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updcaixa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caixal",
                c => new
                    {
                        Caixalstamp = c.String(nullable: false, maxLength: 80),
                        Caixastamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contatesoura = c.String(nullable: false, maxLength: 80),
                        Qmf = c.String(nullable: false, maxLength: 80),
                        Qmfdathora = c.DateTime(nullable: false),
                        Entrada = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Saida = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Saldo = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Lancado = c.Decimal(nullable: false, precision: 16, scale: 2),
                        TotalDefice = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Campo1 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Campo2 = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Campo3 = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 600),
                    })
                .PrimaryKey(t => t.Caixalstamp)
                .ForeignKey("dbo.Caixa", t => t.Caixastamp, cascadeDelete: true)
                .Index(t => t.Caixastamp);
            
            AddColumn("dbo.Caixa", "Qmf", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixa", "Saldo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixa", "Defice", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixa", "Campo1", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixa", "Campo2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixa", "Campo3", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Caixa", "Campo4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixa", "Campo5", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixa", "Supervisor", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Fechacaixa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Abrecaixa", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Caixa", "Obs", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Caixal", "Caixastamp", "dbo.Caixa");
            DropIndex("dbo.Caixal", new[] { "Caixastamp" });
            AlterColumn("dbo.Caixa", "Obs", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Usr", "Abrecaixa");
            DropColumn("dbo.Usr", "Fechacaixa");
            DropColumn("dbo.Caixa", "Supervisor");
            DropColumn("dbo.Caixa", "Campo5");
            DropColumn("dbo.Caixa", "Campo4");
            DropColumn("dbo.Caixa", "Campo3");
            DropColumn("dbo.Caixa", "Campo2");
            DropColumn("dbo.Caixa", "Campo1");
            DropColumn("dbo.Caixa", "Defice");
            DropColumn("dbo.Caixa", "Saldo");
            DropColumn("dbo.Caixa", "Qmf");
            DropTable("dbo.Caixal");
        }
    }
}
