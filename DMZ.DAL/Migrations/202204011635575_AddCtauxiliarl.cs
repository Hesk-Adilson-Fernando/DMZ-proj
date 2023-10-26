namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCtauxiliarl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ctauxiliarl",
                c => new
                    {
                        Ctauxiliarlstamp = c.String(nullable: false, maxLength: 80),
                        Ctauxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Ctauxiliarlstamp)
                .ForeignKey("dbo.Ctauxiliar", t => t.Ctauxiliarstamp, cascadeDelete: true)
                .Index(t => t.Ctauxiliarstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ctauxiliarl", "Ctauxiliarstamp", "dbo.Ctauxiliar");
            DropIndex("dbo.Ctauxiliarl", new[] { "Ctauxiliarstamp" });
            DropTable("dbo.Ctauxiliarl");
        }
    }
}
