namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMvt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mvt",
                c => new
                    {
                        Mvtstamp = c.String(nullable: false, maxLength: 80),
                        Datamov = c.DateTime(nullable: false),
                        Origem = c.String(maxLength: 80),
                        Oristamp = c.String(maxLength: 80),
                        Entrada = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Saida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Local = c.String(maxLength: 80),
                        Codlocal = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Documento = c.String(maxLength: 80),
                        Titulo = c.String(maxLength: 80),
                        Numtitulo = c.String(maxLength: 80),
                        Dprocess = c.DateTime(nullable: false),
                        Process = c.Boolean(nullable: false),
                        Nrdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dpstamp = c.String(maxLength: 80),
                        Moeda = c.String(maxLength: 80),
                        Descricao = c.String(maxLength: 80),
                        Numeracao = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Reconc = c.Boolean(nullable: false),
                        extcontastamp = c.String(maxLength: 80),
                        Extracto = c.String(maxLength: 80),
                        Trfstamp = c.String(maxLength: 80),
                        Banco = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        Contatz = c.Decimal(precision: 9, scale: 0),
                        Referenc = c.String(maxLength: 80),
                        Formaspstamp = c.String(maxLength: 80),
                        peemplstamp = c.String(maxLength: 80),
                        Prcempstamp = c.String(maxLength: 80),
                        Tipomov = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mentrada = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Msaida = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Mvtstamp)
                .ForeignKey("dbo.Formasp", t => t.Formaspstamp)
                .Index(t => t.Formaspstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mvt", "Formaspstamp", "dbo.Formasp");
            DropIndex("dbo.Mvt", new[] { "Formaspstamp" });
            DropTable("dbo.Mvt");
        }
    }
}
