namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtrf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trf",
                c => new
                    {
                        Trfstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Numinterno = c.String(maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Origem = c.String(maxLength: 80),
                        Orinum = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda1 = c.String(maxLength: 80),
                        Destino = c.String(maxLength: 80),
                        Destnum = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Moeda2 = c.String(maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Obs = c.String(maxLength: 80),
                        Titulo = c.String(maxLength: 80),
                        Numtitulo = c.String(maxLength: 80),
                        Ccusto = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Trfstamp);
            
            CreateIndex("dbo.Mvt", "Trfstamp");
            AddForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf", "Trfstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf");
            DropIndex("dbo.Mvt", new[] { "Trfstamp" });
            DropTable("dbo.Trf");
        }
    }
}
