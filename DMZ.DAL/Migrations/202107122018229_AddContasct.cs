namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContasct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contasct",
                c => new
                    {
                        Contasctstamp = c.String(nullable: false, maxLength: 80),
                        Contasstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 80),
                        Descgrupo = c.String(nullable: false, maxLength: 80),
                        Contacc = c.Boolean(nullable: false),
                        MovIntegra = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Contasctstamp)
                .ForeignKey("dbo.Contas", t => t.Contasstamp, cascadeDelete: true)
                .Index(t => t.Contasstamp);
            
            DropColumn("dbo.Contas", "ContaPgc");
            DropColumn("dbo.Contas", "ContaPgc2");
            DropColumn("dbo.Contas", "ContaPgc3");
            DropColumn("dbo.Contas", "ContaPgc4");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contas", "ContaPgc4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "ContaPgc3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "ContaPgc2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Contas", "ContaPgc", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Contasct", "Contasstamp", "dbo.Contas");
            DropIndex("dbo.Contasct", new[] { "Contasstamp" });
            DropTable("dbo.Contasct");
        }
    }
}
