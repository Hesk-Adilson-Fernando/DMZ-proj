namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updgrade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        Grupostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Imagem = c.Binary(),
                    })
                .PrimaryKey(t => t.Grupostamp);
            
            CreateTable(
                "dbo.SubGrupo",
                c => new
                    {
                        SubGrupostamp = c.String(nullable: false, maxLength: 80),
                        Grupostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Imagem = c.Binary(),
                    })
                .PrimaryKey(t => t.SubGrupostamp)
                .ForeignKey("dbo.Grupo", t => t.Grupostamp, cascadeDelete: true)
                .Index(t => t.Grupostamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubGrupo", "Grupostamp", "dbo.Grupo");
            DropIndex("dbo.SubGrupo", new[] { "Grupostamp" });
            DropTable("dbo.SubGrupo");
            DropTable("dbo.Grupo");
        }
    }
}
