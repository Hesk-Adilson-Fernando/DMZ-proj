namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fpagam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fpagam",
                c => new
                    {
                        Fpagamstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(maxLength: 80),
                        Tipo = c.Boolean(nullable: false),
                        ObgTitulo = c.Boolean(nullable: false),
                        Pos = c.Boolean(nullable: false),
                        Numer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Fpagamstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fpagam");
        }
    }
}
