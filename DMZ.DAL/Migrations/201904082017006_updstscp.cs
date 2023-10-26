namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updstscp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StConposto", "Ststamp", "dbo.St");
            DropIndex("dbo.StConposto", new[] { "Ststamp" });
            CreateTable(
                "dbo.Stcp",
                c => new
                    {
                        Stcpstamp = c.String(nullable: false, maxLength: 80),
                        refcp = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        quantcp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Precocp = c.Decimal(nullable: false, precision: 9, scale: 0),
                        stkprod = c.Boolean(nullable: false),
                        servico = c.Boolean(nullable: false),
                        refstk = c.Boolean(nullable: false),
                        ststamp = c.String(maxLength: 80),
                        refst = c.String(maxLength: 80),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Stcpstamp)
                .ForeignKey("dbo.St", t => t.ststamp)
                .Index(t => t.ststamp);
            
            DropTable("dbo.StConposto");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StConposto",
                c => new
                    {
                        StConpostostamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        quantid = c.String(maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.StConpostostamp);
            
            DropForeignKey("dbo.Stcp", "ststamp", "dbo.St");
            DropIndex("dbo.Stcp", new[] { "ststamp" });
            DropTable("dbo.Stcp");
            CreateIndex("dbo.StConposto", "Ststamp");
            AddForeignKey("dbo.StConposto", "Ststamp", "dbo.St", "Ststamp");
        }
    }
}
