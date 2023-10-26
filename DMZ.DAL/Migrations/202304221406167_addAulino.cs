namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAulino : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aulino",
                c => new
                    {
                        Aulinostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Aulinostamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aulino");
        }
    }
}
