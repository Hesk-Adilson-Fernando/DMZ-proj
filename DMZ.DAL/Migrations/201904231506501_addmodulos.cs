namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodulos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modulos",
                c => new
                    {
                        Modulosstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Modulosstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Modulos");
        }
    }
}
