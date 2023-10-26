namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdUsrAcessos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usracessos", "Usracessgrupostamp", "dbo.Usracessgrupo");
            DropIndex("dbo.Usracessgrupo", new[] { "Usrmodulostamp" });
            DropIndex("dbo.Usracessos", new[] { "Usracessgrupostamp" });
            CreateIndex("dbo.Usracessos", "Usrmodulostamp");
            DropColumn("dbo.Usracessos", "Usracessgrupostamp");
            DropTable("dbo.Usracessgrupo");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Usracessgrupo",
                c => new
                    {
                        Usracessgrupostamp = c.String(nullable: false, maxLength: 80),
                        Usrmodulostamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Usrstamp = c.String(nullable: false, maxLength: 80),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Usracessgrupostamp);
            
            AddColumn("dbo.Usracessos", "Usracessgrupostamp", c => c.String(nullable: false, maxLength: 80));
            DropIndex("dbo.Usracessos", new[] { "Usrmodulostamp" });
            CreateIndex("dbo.Usracessos", "Usracessgrupostamp");
            CreateIndex("dbo.Usracessgrupo", "Usrmodulostamp");
            AddForeignKey("dbo.Usracessos", "Usracessgrupostamp", "dbo.Usracessgrupo", "Usracessgrupostamp", cascadeDelete: true);
        }
    }
}
