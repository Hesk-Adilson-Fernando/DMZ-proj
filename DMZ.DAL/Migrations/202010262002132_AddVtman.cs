namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVtman : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vtmanunt",
                c => new
                    {
                        Vtmanuntstamp = c.String(nullable: false, maxLength: 80),
                        Matricula = c.String(nullable: false, maxLength: 80),
                        Data = c.DateTime(nullable: false),
                        Km = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Motorista = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Vtmanuntstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vtmanunt");
        }
    }
}
