namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updstp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StFnc",
                c => new
                    {
                        StFncstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Quant = c.Decimal(nullable: false, precision: 16, scale: 2),
                        obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.StFncstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            AddColumn("dbo.StPrecos", "PrecoCompra", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.StPrecos", "Perc", c => c.Decimal(nullable: false, precision: 4, scale: 2));
            AddColumn("dbo.St", "Usaconvunid", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Quantidade", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Unidsaida", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Stockmin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Stockmax", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Starm", "Ststamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Starm", "StockMin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Starm", "StockMax", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Starm", "Padrao", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Fact", "Subtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "perdesc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "desconto", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Totaliva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Msubtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Mdesconto", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Mtotaliva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Fact", "Mtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Facc", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Facc", "Mtotaliva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Facc", "Mtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.StPrecos", "Preco", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            CreateIndex("dbo.Starm", "Ststamp");
            AddForeignKey("dbo.Starm", "Ststamp", "dbo.St", "Ststamp", cascadeDelete: true);
            DropColumn("dbo.Starm", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Starm", "Status", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.StFnc", "Ststamp", "dbo.St");
            DropForeignKey("dbo.Starm", "Ststamp", "dbo.St");
            DropIndex("dbo.StFnc", new[] { "Ststamp" });
            DropIndex("dbo.Starm", new[] { "Ststamp" });
            AlterColumn("dbo.StPrecos", "Preco", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Facc", "Mtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Facc", "Mtotaliva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Facc", "Total", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Mtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Mtotaliva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Mdesconto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Msubtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Total", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Totaliva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "desconto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "perdesc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Fact", "Subtotal", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Starm", "Padrao");
            DropColumn("dbo.Starm", "StockMax");
            DropColumn("dbo.Starm", "StockMin");
            DropColumn("dbo.Starm", "Ststamp");
            DropColumn("dbo.St", "Stockmax");
            DropColumn("dbo.St", "Stockmin");
            DropColumn("dbo.St", "Unidsaida");
            DropColumn("dbo.St", "Quantidade");
            DropColumn("dbo.St", "Usaconvunid");
            DropColumn("dbo.StPrecos", "Perc");
            DropColumn("dbo.StPrecos", "PrecoCompra");
            DropTable("dbo.StFnc");
        }
    }
}
