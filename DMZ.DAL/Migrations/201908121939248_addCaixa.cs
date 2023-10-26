namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCaixa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caixa",
                c => new
                    {
                        Caixastamp = c.String(nullable: false, maxLength: 80),
                        Numero = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Inicial = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Data = c.DateTime(nullable: false),
                        Codtz = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Contatesoura = c.String(nullable: false, maxLength: 80),
                        Fechado = c.Boolean(nullable: false),
                        obs = c.String(nullable: false, maxLength: 80),
                        qmc = c.String(nullable: false, maxLength: 80),
                        qmcdathora = c.DateTime(nullable: false),
                        qma = c.String(nullable: false, maxLength: 80),
                        qmadathora = c.DateTime(nullable: false),
                        no = c.Decimal(nullable: false, precision: 9, scale: 0),
                        nome = c.String(nullable: false, maxLength: 80),
                        dhorafecho = c.DateTime(nullable: false),
                        posto = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Caixastamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Caixa");
        }
    }
}
