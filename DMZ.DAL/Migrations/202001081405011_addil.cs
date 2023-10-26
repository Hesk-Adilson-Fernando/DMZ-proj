namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addil : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IV",
                c => new
                    {
                        Ivstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        Totaliva = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Impresso = c.Boolean(nullable: false),
                        Usrimpress = c.String(nullable: false, maxLength: 80),
                        Impressodh = c.DateTime(nullable: false),
                        Lancado = c.Boolean(nullable: false),
                        Datalanc = c.DateTime(nullable: false),
                        Usrlanc = c.String(nullable: false, maxLength: 80),
                        Numinterno = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Ivstamp);
            
            CreateTable(
                "dbo.IVL",
                c => new
                    {
                        Ivlstamp = c.String(nullable: false, maxLength: 80),
                        Ivstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Unidade = c.String(nullable: false, maxLength: 80),
                        Armazem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totall = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Status = c.Boolean(nullable: false),
                        Servico = c.Boolean(nullable: false),
                        Difer = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nmovstk = c.Boolean(nullable: false),
                        Remotestamp = c.String(nullable: false, maxLength: 80),
                        Tit = c.Boolean(nullable: false),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Titstamp = c.String(nullable: false, maxLength: 80),
                        Lote = c.String(nullable: false, maxLength: 80),
                        Lotevalid = c.DateTime(nullable: false),
                        lotelimft = c.DateTime(nullable: false),
                        usalote = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ivlstamp)
                .ForeignKey("dbo.IV", t => t.Ivstamp, cascadeDelete: true)
                .Index(t => t.Ivstamp);
            
            CreateIndex("dbo.Mstk", "Ivlstamp");
            AddForeignKey("dbo.Mstk", "Ivlstamp", "dbo.IVL", "Ivlstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mstk", "Ivlstamp", "dbo.IVL");
            DropForeignKey("dbo.IVL", "Ivstamp", "dbo.IV");
            DropIndex("dbo.IVL", new[] { "Ivstamp" });
            DropIndex("dbo.Mstk", new[] { "Ivlstamp" });
            DropTable("dbo.IVL");
            DropTable("dbo.IV");
        }
    }
}
