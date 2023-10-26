namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDRLT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rltusr",
                c => new
                    {
                        Rltusrstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Rltstamp = c.String(nullable: false, maxLength: 80),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Rltusrstamp)
                .ForeignKey("dbo.Rlt", t => t.Rltstamp, cascadeDelete: true)
                .Index(t => t.Rltstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rltusr", "Rltstamp", "dbo.Rlt");
            DropIndex("dbo.Rltusr", new[] { "Rltstamp" });
            DropTable("dbo.Rltusr");
        }
    }
}
