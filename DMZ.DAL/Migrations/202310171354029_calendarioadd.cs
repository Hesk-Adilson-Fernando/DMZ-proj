namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calendarioadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.calendario",
                c => new
                    {
                        calendariostamp = c.String(nullable: false, maxLength: 80),
                        date = c.DateTime(nullable: false),
                        events = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.calendariostamp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.calendario");
        }
    }
}
