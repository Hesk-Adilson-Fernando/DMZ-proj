namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFamiliapb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Familiapb",
                c => new
                    {
                        Familiapbstamp = c.String(nullable: false, maxLength: 80),
                        Familiastamp = c.String(nullable: false, maxLength: 80),
                        Order = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Bagagem = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Familiapbstamp)
                .ForeignKey("dbo.Familia", t => t.Familiastamp, cascadeDelete: true)
                .Index(t => t.Familiastamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Familiapb", "Familiastamp", "dbo.Familia");
            DropIndex("dbo.Familiapb", new[] { "Familiastamp" });
            DropTable("dbo.Familiapb");
        }
    }
}
