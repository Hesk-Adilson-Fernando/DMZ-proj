namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updpe3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PeAuxiliar",
                c => new
                    {
                        PeAuxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tabela = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desctabela = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.PeAuxiliarstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PeAuxiliar");
        }
    }
}
