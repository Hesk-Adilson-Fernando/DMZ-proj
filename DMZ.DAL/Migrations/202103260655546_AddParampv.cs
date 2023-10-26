namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddParampv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parampv",
                c => new
                    {
                        Parampvstamp = c.String(nullable: false, maxLength: 80),
                        Paramstamp = c.String(nullable: false, maxLength: 80),
                        Valor = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Factor = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.Parampvstamp)
                .ForeignKey("dbo.Param", t => t.Paramstamp, cascadeDelete: true)
                .Index(t => t.Paramstamp);
            
            AddColumn("dbo.Param", "Autoprecos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Perlucro", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Usr", "Mostraprcompra", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parampv", "Paramstamp", "dbo.Param");
            DropIndex("dbo.Parampv", new[] { "Paramstamp" });
            DropColumn("dbo.Usr", "Mostraprcompra");
            DropColumn("dbo.Param", "Perlucro");
            DropColumn("dbo.Param", "Autoprecos");
            DropTable("dbo.Parampv");
        }
    }
}
