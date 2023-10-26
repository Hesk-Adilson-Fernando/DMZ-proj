namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDiasFeria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiasFeria",
                c => new
                    {
                        DiasFeriastamp = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Dias = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Ordem = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.DiasFeriastamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DiasFeria");
        }
    }
}
