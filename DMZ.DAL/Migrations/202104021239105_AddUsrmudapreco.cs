namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsrmudapreco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usrmudapreco",
                c => new
                    {
                        Usrmudaprecostamp = c.String(nullable: false, maxLength: 80),
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        Usrvenda = c.String(nullable: false, maxLength: 80),
                        Usrsupervidor = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(nullable: false, maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Precoalter = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Data = c.DateTime(nullable: false),
                        Docstamp = c.String(nullable: false, maxLength: 80),
                        Origem = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Usrmudaprecostamp)
                .ForeignKey("dbo.Usr", t => t.Usrstamp, cascadeDelete: true)
                .Index(t => t.Usrstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usrmudapreco", "Usrstamp", "dbo.Usr");
            DropIndex("dbo.Usrmudapreco", new[] { "Usrstamp" });
            DropTable("dbo.Usrmudapreco");
        }
    }
}
