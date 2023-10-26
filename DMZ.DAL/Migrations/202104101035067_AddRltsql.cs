namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRltsql : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rltsql",
                c => new
                    {
                        Rltsqlstamp = c.String(nullable: false, maxLength: 80),
                        Querry = c.String(nullable: false, maxLength: 1200),
                        Origem = c.String(nullable: false, maxLength: 80),
                        Reportname = c.String(nullable: false, maxLength: 80),
                        Tamanho = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Rltsqlstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rltsql");
        }
    }
}
