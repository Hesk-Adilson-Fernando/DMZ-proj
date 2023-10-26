namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pv",
                c => new
                    {
                        Pvstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Cx = c.String(nullable: false, maxLength: 80),
                        CodCaixa = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.Pvstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pv");
        }
    }
}
