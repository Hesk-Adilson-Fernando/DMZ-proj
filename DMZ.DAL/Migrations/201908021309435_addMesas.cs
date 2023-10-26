namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMesas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mesas",
                c => new
                    {
                        Mesasstamp = c.String(nullable: false, maxLength: 80),
                        Mesano = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Imagem = c.Binary(),
                        Inactivo = c.Boolean(nullable: false),
                        TopImg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        LeftImg = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Codloc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        DescLocal = c.String(nullable: false, maxLength: 80),
                        LocMesasstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Mesasstamp);
            
            CreateTable(
                "dbo.SectMesas",
                c => new
                    {
                        Sectmesasstamp = c.String(nullable: false, maxLength: 80),
                        Mesasstamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sectorstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Sectmesasstamp)
                .ForeignKey("dbo.Sector", t => t.Sectorstamp, cascadeDelete: true)
                .Index(t => t.Sectorstamp);
            
            CreateTable(
                "dbo.Sector",
                c => new
                    {
                        Sectorstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Sectorstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SectMesas", "Sectorstamp", "dbo.Sector");
            DropIndex("dbo.SectMesas", new[] { "Sectorstamp" });
            DropTable("dbo.Sector");
            DropTable("dbo.SectMesas");
            DropTable("dbo.Mesas");
        }
    }
}
