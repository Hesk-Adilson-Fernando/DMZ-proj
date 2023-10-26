namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRdlcxml : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rdlcxml",
                c => new
                    {
                        RdlcxmLstamp = c.String(nullable: false, maxLength: 80),
                        Xmlstring = c.String(nullable: false),
                        Rdlcname = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.RdlcxmLstamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rdlcxml");
        }
    }
}
