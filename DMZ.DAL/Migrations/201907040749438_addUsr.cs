namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usracessos",
                c => new
                    {
                        Usracessostamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        ver = c.Boolean(nullable: false),
                        intro = c.Boolean(nullable: false),
                        altera = c.Boolean(nullable: false),
                        apaga = c.Boolean(nullable: false),
                        anula = c.Boolean(nullable: false),
                        imprimir = c.Boolean(nullable: false),
                        Usrmodulostamp = c.String(nullable: false, maxLength: 80),
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        ecran = c.String(nullable: false, maxLength: 80),
                        tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        sigla = c.String(nullable: false, maxLength: 80),
                        numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        numrlt = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        codmodulo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        codmenu = c.Decimal(nullable: false, precision: 9, scale: 0),
                        ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                        headgroup = c.Boolean(nullable: false),
                        activo = c.Boolean(nullable: false),
                        painel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Usracessostamp)
                .ForeignKey("dbo.UsrModulo", t => t.Usrmodulostamp, cascadeDelete: true)
                .Index(t => t.Usrmodulostamp);
            
            CreateTable(
                "dbo.UsrModulo",
                c => new
                    {
                        Usrmodulostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        status = c.Boolean(nullable: false),
                        activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Usrmodulostamp);
            
            AddColumn("dbo.Usr", "Contacto", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Usr", "Processo");
            DropColumn("dbo.Usr", "Cadastro");
            DropColumn("dbo.Usr", "Tabelas");
            DropColumn("dbo.Usr", "Relatorio");
            DropColumn("dbo.Usr", "Contacto1");
            DropColumn("dbo.Usr", "Contacto2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usr", "Contacto2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Contacto1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Relatorio", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Tabelas", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Cadastro", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Processo", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Usracessos", "Usrmodulostamp", "dbo.UsrModulo");
            DropIndex("dbo.Usracessos", new[] { "Usrmodulostamp" });
            DropColumn("dbo.Usr", "Contacto");
            DropTable("dbo.UsrModulo");
            DropTable("dbo.Usracessos");
        }
    }
}
