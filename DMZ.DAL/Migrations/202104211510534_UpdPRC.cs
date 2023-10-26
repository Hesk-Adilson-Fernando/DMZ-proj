namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPRC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prcdesc",
                c => new
                    {
                        Prcdescstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Taxa = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                        Tipodesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fixo = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Taxa2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor2 = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Prcdescstamp)
                .ForeignKey("dbo.Prc", t => t.Prcstamp, cascadeDelete: true)
                .Index(t => t.Prcstamp);
            
            CreateTable(
                "dbo.Prcsub",
                c => new
                    {
                        Prcsubstamp = c.String(nullable: false, maxLength: 30),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Taxa = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                        Tiposub = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Tipo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fixo = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Prcsubstamp)
                .ForeignKey("dbo.Prc", t => t.Prcstamp, cascadeDelete: true)
                .Index(t => t.Prcstamp);
            
            AddColumn("dbo.Prc", "Proces_Processtamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Prcextra", "Prc_Prcstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Prcemp", "Prcstamp");
            CreateIndex("dbo.Prc", "Proces_Processtamp");
            CreateIndex("dbo.Prcextra", "Prc_Prcstamp");
            AddForeignKey("dbo.Prcemp", "Prcstamp", "dbo.Prc", "Prcstamp", cascadeDelete: true);
            AddForeignKey("dbo.Prc", "Proces_Processtamp", "dbo.Proces", "Processtamp");
            AddForeignKey("dbo.Prcextra", "Prc_Prcstamp", "dbo.Prc", "Prcstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prcsub", "Prcstamp", "dbo.Prc");
            DropForeignKey("dbo.Prcextra", "Prc_Prcstamp", "dbo.Prc");
            DropForeignKey("dbo.Prc", "Proces_Processtamp", "dbo.Proces");
            DropForeignKey("dbo.Prcemp", "Prcstamp", "dbo.Prc");
            DropForeignKey("dbo.Prcdesc", "Prcstamp", "dbo.Prc");
            DropIndex("dbo.Prcsub", new[] { "Prcstamp" });
            DropIndex("dbo.Prcextra", new[] { "Prc_Prcstamp" });
            DropIndex("dbo.Prcdesc", new[] { "Prcstamp" });
            DropIndex("dbo.Prc", new[] { "Proces_Processtamp" });
            DropIndex("dbo.Prcemp", new[] { "Prcstamp" });
            DropColumn("dbo.Prcextra", "Prc_Prcstamp");
            DropColumn("dbo.Prc", "Proces_Processtamp");
            DropTable("dbo.Prcsub");
            DropTable("dbo.Prcdesc");
        }
    }
}
