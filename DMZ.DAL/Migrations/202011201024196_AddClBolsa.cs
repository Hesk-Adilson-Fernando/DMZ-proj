namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClBolsa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClBolsa",
                c => new
                    {
                        ClBolsastamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Instituicao = c.String(nullable: false, maxLength: 80),
                        Tipobolsa = c.String(nullable: false, maxLength: 80),
                        Datain = c.DateTime(nullable: false),
                        Datatermino = c.DateTime(nullable: false),
                        Anolectivo = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Perc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(nullable: false, maxLength: 600),
                    })
                .PrimaryKey(t => t.ClBolsastamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClBolsa", "Clstamp", "dbo.Cl");
            DropIndex("dbo.ClBolsa", new[] { "Clstamp" });
            DropTable("dbo.ClBolsa");
        }
    }
}
