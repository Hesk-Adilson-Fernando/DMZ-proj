namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPrcempr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prcemp", "Peemplstamp", "dbo.Peempl");
            DropForeignKey("dbo.Prcextra", "Processtamp", "dbo.Proces");
            DropIndex("dbo.Prcemp", new[] { "Peemplstamp" });
            DropIndex("dbo.Prcextra", new[] { "Processtamp" });
            AddColumn("dbo.Prc", "Pefaltastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "Pehextrastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Prc", "TotalEmprestimo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalEmprestimo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropTable("dbo.Prcemp");
            DropTable("dbo.Prcextra");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Prcextra",
                c => new
                    {
                        Prcextrastamp = c.String(nullable: false, maxLength: 30),
                        Processtamp = c.String(nullable: false, maxLength: 80),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Codcat = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cat = c.String(nullable: false, maxLength: 80),
                        Coddesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codfun = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Escalao = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Indice = c.String(nullable: false, maxLength: 80),
                        Codsec = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codcl = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Classe = c.String(nullable: false, maxLength: 80),
                        Quota = c.Boolean(nullable: false),
                        Sind = c.String(nullable: false, maxLength: 80),
                        Nsind = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codsit = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Situacao = c.String(nullable: false, maxLength: 80),
                        Basecateg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totsub = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totabonus = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Totdesc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Liquido = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Fechado = c.Boolean(nullable: false),
                        Extra = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Total = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Diferenca = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Prcextrastamp);
            
            CreateTable(
                "dbo.Prcemp",
                c => new
                    {
                        Prcempstamp = c.String(nullable: false, maxLength: 30),
                        Nrmes = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Mes = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Peemplstamp = c.String(nullable: false, maxLength: 80),
                        Prcstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Prcempstamp);
            
            DropColumn("dbo.Proces", "TotalEmprestimo");
            DropColumn("dbo.Prc", "TotalEmprestimo");
            DropColumn("dbo.Prc", "Pehextrastamp");
            DropColumn("dbo.Prc", "Pefaltastamp");
            CreateIndex("dbo.Prcextra", "Processtamp");
            CreateIndex("dbo.Prcemp", "Peemplstamp");
            AddForeignKey("dbo.Prcextra", "Processtamp", "dbo.Proces", "Processtamp", cascadeDelete: true);
            AddForeignKey("dbo.Prcemp", "Peemplstamp", "dbo.Peempl", "Peemplstamp", cascadeDelete: true);
        }
    }
}
