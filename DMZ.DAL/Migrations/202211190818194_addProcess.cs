namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProcess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Processo",
                c => new
                    {
                        Processostamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        Dataven = c.DateTime(nullable: false),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Processostamp);
            
            CreateTable(
                "dbo.Processol",
                c => new
                    {
                        Processolstamp = c.String(nullable: false, maxLength: 80),
                        Processostamp = c.String(nullable: false, maxLength: 80),
                        Ref = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Datain = c.DateTime(nullable: false),
                        Datafim = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Processolstamp)
                .ForeignKey("dbo.Processo", t => t.Processostamp, cascadeDelete: true)
                .Index(t => t.Processostamp);
            
            CreateTable(
                "dbo.Tdocpe",
                c => new
                    {
                        Tdocpestamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Tdocpestamp);
            
            AddColumn("dbo.Pecontra", "Anexo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processol", "Processostamp", "dbo.Processo");
            DropIndex("dbo.Processol", new[] { "Processostamp" });
            DropColumn("dbo.Pecontra", "Anexo");
            DropTable("dbo.Tdocpe");
            DropTable("dbo.Processol");
            DropTable("dbo.Processo");
        }
    }
}
