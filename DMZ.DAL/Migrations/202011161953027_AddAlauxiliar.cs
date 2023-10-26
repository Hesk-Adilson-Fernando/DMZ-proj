namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAlauxiliar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alauxiliar",
                c => new
                    {
                        Alauxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                        Tabela = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desctabela = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Alauxiliarstamp);
            
            CreateTable(
                "dbo.Alauxiliarl",
                c => new
                    {
                        Alauxiliarlstamp = c.String(nullable: false, maxLength: 80),
                        Alauxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Alauxiliarlstamp)
                .ForeignKey("dbo.Alauxiliar", t => t.Alauxiliarstamp, cascadeDelete: true)
                .Index(t => t.Alauxiliarstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alauxiliarl", "Alauxiliarstamp", "dbo.Alauxiliar");
            DropIndex("dbo.Alauxiliarl", new[] { "Alauxiliarstamp" });
            DropTable("dbo.Alauxiliarl");
            DropTable("dbo.Alauxiliar");
        }
    }
}
