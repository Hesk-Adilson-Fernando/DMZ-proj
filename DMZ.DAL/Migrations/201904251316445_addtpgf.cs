namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtpgf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tpgf",
                c => new
                    {
                        Tpgfstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Descmovcc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contastesoura = c.String(maxLength: 80),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Titulo = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Entida = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Activo = c.Boolean(nullable: false),
                        Defa = c.Boolean(nullable: false),
                        Qmc = c.String(maxLength: 80),
                        Qmcdathora = c.DateTime(nullable: false),
                        Qma = c.String(maxLength: 80),
                        Qmadathora = c.DateTime(nullable: false),
                        Integra = c.Boolean(nullable: false),
                        Nodiario = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Diario = c.String(maxLength: 80),
                        NdocCont = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescDocCont = c.String(maxLength: 80),
                        TesouraPgc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Etpemiss = c.Boolean(nullable: false),
                        Etpimpress = c.Boolean(nullable: false),
                        Etpemail = c.Boolean(nullable: false),
                        Etpemisstxt = c.String(maxLength: 80),
                        Etpimpresstxt = c.String(maxLength: 80),
                        Etpemailtxt = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Tpgfstamp);
            
            CreateIndex("dbo.Docmodulo", "Tpgfstamp");
            AddForeignKey("dbo.Docmodulo", "Tpgfstamp", "dbo.Tpgf", "Tpgfstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Docmodulo", "Tpgfstamp", "dbo.Tpgf");
            DropIndex("dbo.Docmodulo", new[] { "Tpgfstamp" });
            DropTable("dbo.Tpgf");
        }
    }
}
