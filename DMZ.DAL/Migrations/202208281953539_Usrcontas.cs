namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usrcontas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usrcontas",
                c => new
                    {
                        Usrcontasstamp = c.String(nullable: false, maxLength: 80),
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        Conta = c.String(nullable: false, maxLength: 90),
                        Contasstamp = c.String(nullable: false, maxLength: 90),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Cx = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Usrcontasstamp)
                .ForeignKey("dbo.Usr", t => t.Usrstamp, cascadeDelete: true)
                .Index(t => t.Usrstamp);
            
            AddColumn("dbo.Ccu_Caixa", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usrcontas", "Usrstamp", "dbo.Usr");
            DropIndex("dbo.Usrcontas", new[] { "Usrstamp" });
            DropColumn("dbo.Ccu_Caixa", "Contasstamp");
            DropTable("dbo.Usrcontas");
        }
    }
}
