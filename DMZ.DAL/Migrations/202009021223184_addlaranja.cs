namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlaranja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Laranja",
                c => new
                    {
                        Laranjastamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Laranjastamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Laranja");
        }
    }
}
