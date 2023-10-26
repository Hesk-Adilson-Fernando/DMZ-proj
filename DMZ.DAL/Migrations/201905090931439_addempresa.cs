namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addempresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        Empresastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Morada = c.String(nullable: false, maxLength: 80),
                        Morada2 = c.String(nullable: false, maxLength: 80),
                        Sede = c.String(nullable: false, maxLength: 80),
                        Telefone = c.String(nullable: false, maxLength: 80),
                        Fax = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                        Cell = c.String(nullable: false, maxLength: 80),
                        cp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Actividade = c.String(nullable: false, maxLength: 80),
                        Nuit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        MoedaMT = c.String(nullable: false, maxLength: 80),
                        Infobanc = c.String(nullable: false, maxLength: 80),
                        Declarante = c.String(nullable: false, maxLength: 80),
                        Refdeclara = c.String(nullable: false, maxLength: 80),
                        logo = c.Byte(nullable: false),
                        Webpage = c.String(nullable: false, maxLength: 80),
                        Empslogan = c.String(nullable: false, maxLength: 80),
                        Actdgi = c.String(nullable: false, maxLength: 80),
                        Reparticao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Empresastamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresa");
        }
    }
}
