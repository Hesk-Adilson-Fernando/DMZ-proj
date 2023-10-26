namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFactConcet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FactConcet",
                c => new
                    {
                        FactConcetstamp = c.String(nullable: false, maxLength: 80),
                        UsrCode = c.String(nullable: false, maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Bomba = c.String(nullable: false, maxLength: 80),
                        Bico = c.String(nullable: false, maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Combustivel = c.String(nullable: false, maxLength: 80),
                        Tipocomb = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.FactConcetstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FactConcet");
        }
    }
}
