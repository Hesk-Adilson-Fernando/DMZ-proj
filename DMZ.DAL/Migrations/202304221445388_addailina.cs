namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addailina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aulinol",
                c => new
                    {
                        Aulinolstamp = c.String(nullable: false, maxLength: 80),
                        Aulinostamp = c.String(nullable: false, maxLength: 80),
                        Campo1 = c.String(nullable: false, maxLength: 80),
                        Campo2 = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Aulinolstamp)
                .ForeignKey("dbo.Aulino", t => t.Aulinostamp, cascadeDelete: true)
                .Index(t => t.Aulinostamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aulinol", "Aulinostamp", "dbo.Aulino");
            DropIndex("dbo.Aulinol", new[] { "Aulinostamp" });
            DropTable("dbo.Aulinol");
        }
    }
}
