namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrltcc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RltCc",
                c => new
                    {
                        RltCcstamp = c.String(nullable: false, maxLength: 80),
                        Ccusto = c.String(nullable: false, maxLength: 80),
                        Codccu = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Estado = c.Boolean(nullable: false),
                        Rltstamp = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.RltCcstamp)
                .ForeignKey("dbo.Rlt", t => t.Rltstamp, cascadeDelete: true)
                .Index(t => t.Rltstamp);
            
            DropColumn("dbo.Rlt", "Ccusto");
            DropColumn("dbo.Rlt", "Codccu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rlt", "Codccu", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Rlt", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.RltCc", "Rltstamp", "dbo.Rlt");
            DropIndex("dbo.RltCc", new[] { "Rltstamp" });
            DropTable("dbo.RltCc");
        }
    }
}
