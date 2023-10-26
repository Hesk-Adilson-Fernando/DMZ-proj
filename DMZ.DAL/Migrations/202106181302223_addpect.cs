namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpect : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pect",
                c => new
                    {
                        Pectstamp = c.String(nullable: false, maxLength: 80),
                        Pestamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descgrupo = c.String(nullable: false, maxLength: 80),
                        Contacc = c.Boolean(nullable: false),
                        MovIntegra = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Pectstamp)
                .ForeignKey("dbo.Pe", t => t.Pestamp, cascadeDelete: true)
                .Index(t => t.Pestamp);
            
            AddColumn("dbo.Paramgct", "Padrao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramgct", "Tipo", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Paramgct", "Cl");
            DropColumn("dbo.Paramgct", "Cc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Paramgct", "Cc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramgct", "Cl", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Pect", "Pestamp", "dbo.Pe");
            DropIndex("dbo.Pect", new[] { "Pestamp" });
            DropColumn("dbo.Paramgct", "Tipo");
            DropColumn("dbo.Paramgct", "Padrao");
            DropTable("dbo.Pect");
        }
    }
}
