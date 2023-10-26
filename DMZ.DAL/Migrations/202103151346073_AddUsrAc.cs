namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsrAc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usracessos", "Usrmodulostamp", "dbo.UsrModulo");
            DropIndex("dbo.Usracessos", new[] { "Usrmodulostamp" });
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
                .PrimaryKey(t => t.Usracessgrupostamp)
                .ForeignKey("dbo.UsrModulo", t => t.Usrmodulostamp, cascadeDelete: true)
                .Index(t => t.Usrmodulostamp);
            
            AddColumn("dbo.Usracessos", "Usracessgrupostamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Usracessos", "Usracessgrupostamp");
            AddForeignKey("dbo.Usracessos", "Usracessgrupostamp", "dbo.Usracessgrupo", "Usracessgrupostamp", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usracessgrupo", "Usrmodulostamp", "dbo.UsrModulo");
            DropForeignKey("dbo.Usracessos", "Usracessgrupostamp", "dbo.Usracessgrupo");
            DropIndex("dbo.Usracessos", new[] { "Usracessgrupostamp" });
            DropIndex("dbo.Usracessgrupo", new[] { "Usrmodulostamp" });
            DropColumn("dbo.Usracessos", "Usracessgrupostamp");
            DropTable("dbo.Usracessgrupo");
            CreateIndex("dbo.Usracessos", "Usrmodulostamp");
            AddForeignKey("dbo.Usracessos", "Usrmodulostamp", "dbo.UsrModulo", "Usrmodulostamp", cascadeDelete: true);
        }
    }
}
