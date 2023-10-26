namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCambio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cambio",
                c => new
                    {
                        Cambiostamp = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Compra = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Venda = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Cambiostamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cambio");
        }
    }
}
