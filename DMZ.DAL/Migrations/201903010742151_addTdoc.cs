namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTdoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Codcc",
                c => new
                    {
                        Codccstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Codccstamp);
            
            CreateTable(
                "dbo.Codstk",
                c => new
                    {
                        Codstkstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Codstkstamp);
            
            CreateTable(
                "dbo.Tdoc",
                c => new
                    {
                        Tdocstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(maxLength: 80),
                        Movstk = c.Boolean(nullable: false),
                        Movcc = c.Boolean(nullable: false),
                        Descmovcc = c.String(maxLength: 80),
                        Codmovcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codmovstk = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descmovstk = c.String(maxLength: 80),
                        Movtz = c.Boolean(nullable: false),
                        Obgcc = c.Boolean(nullable: false),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contastesoura = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        CCusto = c.String(maxLength: 80),
                        Codcc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        NCredito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Tdocstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tdoc");
            DropTable("dbo.Codstk");
            DropTable("dbo.Codcc");
        }
    }
}
