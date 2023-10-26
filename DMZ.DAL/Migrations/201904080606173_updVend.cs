namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updVend : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vend",
                c => new
                    {
                        Vendstamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(maxLength: 80),
                        Nuit = c.String(maxLength: 80),
                        Codccu = c.Decimal(nullable: false, precision: 9, scale: 0),
                        CCusto = c.String(maxLength: 80),
                        Telefone = c.String(maxLength: 80),
                        Celucar = c.String(maxLength: 80),
                        Email = c.String(maxLength: 80),
                        Morada = c.String(maxLength: 80),
                        Tipo = c.String(maxLength: 80),
                        Obs = c.String(maxLength: 80),
                        Status = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Vendstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vend");
        }
    }
}
