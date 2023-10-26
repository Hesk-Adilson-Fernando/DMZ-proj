namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpje : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pjpe",
                c => new
                    {
                        Pjpestamp = c.String(nullable: false, maxLength: 80),
                        Pjstamp = c.String(nullable: false, maxLength: 80),
                        No = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Nome = c.String(nullable: false, maxLength: 80),
                        funcao = c.String(nullable: false, maxLength: 80),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Pjpestamp)
                .ForeignKey("dbo.Pj", t => t.Pjstamp, cascadeDelete: true)
                .Index(t => t.Pjstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pjpe", "Pjstamp", "dbo.Pj");
            DropIndex("dbo.Pjpe", new[] { "Pjstamp" });
            DropTable("dbo.Pjpe");
        }
    }
}
