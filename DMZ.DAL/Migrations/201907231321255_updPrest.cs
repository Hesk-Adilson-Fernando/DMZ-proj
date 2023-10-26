namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPrest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factprest",
                c => new
                    {
                        Factpreststamp = c.String(nullable: false, maxLength: 80),
                        Factstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Perc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Factpreststamp)
                .ForeignKey("dbo.Fact", t => t.Factstamp, cascadeDelete: true)
                .Index(t => t.Factstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factprest", "Factstamp", "dbo.Fact");
            DropIndex("dbo.Factprest", new[] { "Factstamp" });
            DropTable("dbo.Factprest");
        }
    }
}
