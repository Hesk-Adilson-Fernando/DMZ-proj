namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clas",
                c => new
                    {
                        Classtamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Classtamp);
            
            CreateTable(
                "dbo.Part",
                c => new
                    {
                        Partstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Partstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Part");
            DropTable("dbo.Clas");
        }
    }
}
