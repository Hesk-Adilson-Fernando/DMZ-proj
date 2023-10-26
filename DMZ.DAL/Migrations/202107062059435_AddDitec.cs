namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDitec : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ditec",
                c => new
                    {
                        Ditecstamp = c.String(nullable: false, maxLength: 80),
                        Distamp = c.String(nullable: false, maxLength: 80),
                        No = c.String(nullable: false, maxLength: 80),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Funcao = c.String(nullable: false, maxLength: 300),
                        Chefe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ditecstamp)
                .ForeignKey("dbo.Di", t => t.Distamp, cascadeDelete: true)
                .Index(t => t.Distamp);
            
            AddColumn("dbo.Di", "Manutantecipada", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ditec", "Distamp", "dbo.Di");
            DropIndex("dbo.Ditec", new[] { "Distamp" });
            DropColumn("dbo.Di", "Manutantecipada");
            DropTable("dbo.Ditec");
        }
    }
}
