namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updProces : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prcextra", "Processstamp", "dbo.Process");
            DropIndex("dbo.Prcextra", new[] { "Processstamp" });
            CreateTable(
                "dbo.Proces",
                c => new
                    {
                        Processtamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Processado = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ultproc = c.DateTime(nullable: false),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Processtamp);
            
            AddColumn("dbo.Prcextra", "Processtamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Prcextra", "Processtamp");
            AddForeignKey("dbo.Prcextra", "Processtamp", "dbo.Proces", "Processtamp", cascadeDelete: true);
            DropColumn("dbo.Prcextra", "Processstamp");
            DropTable("dbo.Process");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Process",
                c => new
                    {
                        Processstamp = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Processado = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ultproc = c.DateTime(nullable: false),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Processstamp);
            
            AddColumn("dbo.Prcextra", "Processstamp", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Prcextra", "Processtamp", "dbo.Proces");
            DropIndex("dbo.Prcextra", new[] { "Processtamp" });
            DropColumn("dbo.Prcextra", "Processtamp");
            DropTable("dbo.Proces");
            CreateIndex("dbo.Prcextra", "Processstamp");
            AddForeignKey("dbo.Prcextra", "Processstamp", "dbo.Process", "Processstamp", cascadeDelete: true);
        }
    }
}
