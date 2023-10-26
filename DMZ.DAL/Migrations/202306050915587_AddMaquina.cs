namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaquina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Familiacar",
                c => new
                    {
                        Familiacarstamp = c.String(nullable: false, maxLength: 80),
                        Familiastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Familiacarstamp)
                .ForeignKey("dbo.Familia", t => t.Familiastamp, cascadeDelete: true)
                .Index(t => t.Familiastamp);
            
            CreateTable(
                "dbo.Familiacarl",
                c => new
                    {
                        Familiacarlstamp = c.String(nullable: false, maxLength: 80),
                        Familiacarstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Descviatura = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Familiacarlstamp)
                .ForeignKey("dbo.Familiacar", t => t.Familiacarstamp, cascadeDelete: true)
                .Index(t => t.Familiacarstamp);
            
            CreateTable(
                "dbo.Stmaq",
                c => new
                    {
                        Stmaqstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Maquinastamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Stmaqstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.Stpe",
                c => new
                    {
                        Stpestamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Stpestamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            CreateTable(
                "dbo.Maquina",
                c => new
                    {
                        Maquinastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Status = c.String(nullable: false, maxLength: 80),
                        Numero = c.String(nullable: false, maxLength: 80),
                        IMEI = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Maquinastamp);
            
            AddColumn("dbo.St", "Bilhete", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Bilheteespecial", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stpe", "Ststamp", "dbo.St");
            DropForeignKey("dbo.Stmaq", "Ststamp", "dbo.St");
            DropForeignKey("dbo.Familiacarl", "Familiacarstamp", "dbo.Familiacar");
            DropForeignKey("dbo.Familiacar", "Familiastamp", "dbo.Familia");
            DropIndex("dbo.Stpe", new[] { "Ststamp" });
            DropIndex("dbo.Stmaq", new[] { "Ststamp" });
            DropIndex("dbo.Familiacarl", new[] { "Familiacarstamp" });
            DropIndex("dbo.Familiacar", new[] { "Familiastamp" });
            DropColumn("dbo.St", "Bilheteespecial");
            DropColumn("dbo.St", "Bilhete");
            DropTable("dbo.Maquina");
            DropTable("dbo.Stpe");
            DropTable("dbo.Stmaq");
            DropTable("dbo.Familiacarl");
            DropTable("dbo.Familiacar");
        }
    }
}
