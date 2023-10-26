namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addparam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Param",
                c => new
                    {
                        Paramstamp = c.String(nullable: false, maxLength: 80),
                        Codprod = c.String(nullable: false, maxLength: 80),
                        CodprodMascra = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Paramstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Param");
        }
    }
}
