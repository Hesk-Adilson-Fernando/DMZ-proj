namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPlanoFeria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlanoFeria",
                c => new
                    {
                        PlanoFeriastamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 600),
                        Ano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Dataplano = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlanoFeriastamp);
            
            CreateTable(
                "dbo.PlanoFerial",
                c => new
                    {
                        PlanoFerialstamp = c.String(nullable: false, maxLength: 80),
                        PlanoFeriastamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Saldoferia = c.Decimal(nullable: false, precision: 10, scale: 2),
                        Datain = c.DateTime(nullable: false),
                        Datater = c.DateTime(nullable: false),
                        Diasnaouteis = c.Decimal(nullable: false, precision: 10, scale: 2),
                        Diasuteis = c.Decimal(nullable: false, precision: 10, scale: 2),
                        Totaldias = c.Decimal(nullable: false, precision: 10, scale: 2),
                    })
                .PrimaryKey(t => t.PlanoFerialstamp)
                .ForeignKey("dbo.PlanoFeria", t => t.PlanoFeriastamp, cascadeDelete: true)
                .Index(t => t.PlanoFeriastamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlanoFerial", "PlanoFeriastamp", "dbo.PlanoFeria");
            DropIndex("dbo.PlanoFerial", new[] { "PlanoFeriastamp" });
            DropTable("dbo.PlanoFerial");
            DropTable("dbo.PlanoFeria");
        }
    }
}
