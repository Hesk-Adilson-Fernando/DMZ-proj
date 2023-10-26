namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoraextra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Falta",
                c => new
                    {
                        Faltastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        DescontaSubAlimenta = c.Boolean(nullable: false),
                        DescontaSubPorTurno = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Faltastamp);
            
            CreateTable(
                "dbo.HoraExtra",
                c => new
                    {
                        HoraExtrastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        ValorPorHora = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.HoraExtrastamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoraExtra");
            DropTable("dbo.Falta");
        }
    }
}
