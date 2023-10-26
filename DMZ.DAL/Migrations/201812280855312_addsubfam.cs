namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsubfam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Familia",
                c => new
                    {
                        Familiastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        Imagem = c.Byte(nullable: false),
                        Pos = c.Boolean(nullable: false),
                        Descpos = c.Boolean(nullable: false),
                        Sequenc = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Familiastamp);
            
            CreateTable(
                "dbo.SubFam",
                c => new
                    {
                        Subfamstamp = c.String(nullable: false, maxLength: 80),
                        Familiastamp = c.String(maxLength: 80),
                        Codigo = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        Imagem = c.Byte(nullable: false),
                        Pos = c.Boolean(nullable: false),
                        Descpos = c.Boolean(nullable: false),
                        Sequenc = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Subfamstamp)
                .ForeignKey("dbo.Familia", t => t.Familiastamp)
                .Index(t => t.Familiastamp);
            
            CreateTable(
                "dbo.Usr",
                c => new
                    {
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(maxLength: 80),
                        Login = c.String(maxLength: 80),
                        Activo = c.Boolean(nullable: false),
                        Usradmin = c.Boolean(nullable: false),
                        Processo = c.Boolean(nullable: false),
                        Cadastro = c.Boolean(nullable: false),
                        Tabelas = c.Boolean(nullable: false),
                        Relatorio = c.Boolean(nullable: false),
                        Email = c.String(maxLength: 80),
                        Contacto1 = c.String(maxLength: 80),
                        Contacto2 = c.String(maxLength: 80),
                        Pw = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Usrstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubFam", "Familiastamp", "dbo.Familia");
            DropIndex("dbo.SubFam", new[] { "Familiastamp" });
            DropTable("dbo.Usr");
            DropTable("dbo.SubFam");
            DropTable("dbo.Familia");
        }
    }
}
