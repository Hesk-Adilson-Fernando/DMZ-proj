namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPlanoaval3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Planoaval",
                c => new
                    {
                        Planoavalstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Anosem = c.String(nullable: false, maxLength: 80),
                        AnoSemstamp = c.String(nullable: false, maxLength: 80),
                        Formulademedia = c.String(nullable: false, maxLength: 80),
                        Formulademediafinal = c.String(nullable: false, maxLength: 80),
                        Dispensa = c.Boolean(nullable: false),
                        Notadisp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nraval = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Exclui = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Planoavalstamp);
            
            CreateTable(
                "dbo.Planoavall",
                c => new
                    {
                        Planoavallstamp = c.String(nullable: false, maxLength: 80),
                        Planoavalstamp = c.String(nullable: false, maxLength: 80),
                        Notain = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Notafin = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Estado = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Planoavallstamp)
                .ForeignKey("dbo.Planoaval", t => t.Planoavalstamp, cascadeDelete: true)
                .Index(t => t.Planoavalstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planoavall", "Planoavalstamp", "dbo.Planoaval");
            DropIndex("dbo.Planoavall", new[] { "Planoavalstamp" });
            DropTable("dbo.Planoavall");
            DropTable("dbo.Planoaval");
        }
    }
}
