namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rltmapa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rltmapa",
                c => new
                    {
                        Rltmapastamp = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Tamanho = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Alinhamento = c.String(nullable: false, maxLength: 80),
                        Formatacao = c.String(nullable: false, maxLength: 80),
                        DataPropertyName = c.String(nullable: false, maxLength: 80),
                        Rlt_Rltstamp = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Rltmapastamp)
                .ForeignKey("dbo.Rlt", t => t.Rlt_Rltstamp)
                .Index(t => t.Rlt_Rltstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rltmapa", "Rlt_Rltstamp", "dbo.Rlt");
            DropIndex("dbo.Rltmapa", new[] { "Rlt_Rltstamp" });
            DropTable("dbo.Rltmapa");
        }
    }
}
