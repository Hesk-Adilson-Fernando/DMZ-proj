namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModulosFrm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modulosfrmdoc",
                c => new
                    {
                        Modulosfrmdocstamp = c.String(nullable: false, maxLength: 80),
                        Modulosstamp = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Ecran = c.String(nullable: false, maxLength: 80),
                        Origem = c.String(nullable: false, maxLength: 80),
                        Obs = c.String(nullable: false, maxLength: 80),
                        Isdoc = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Modulosfrmdocstamp)
                .ForeignKey("dbo.Modulos", t => t.Modulosstamp, cascadeDelete: true)
                .Index(t => t.Modulosstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Modulosfrmdoc", "Modulosstamp", "dbo.Modulos");
            DropIndex("dbo.Modulosfrmdoc", new[] { "Modulosstamp" });
            DropTable("dbo.Modulosfrmdoc");
        }
    }
}
