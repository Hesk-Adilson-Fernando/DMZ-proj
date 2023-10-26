namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiarioclasse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dclasse",
                c => new
                    {
                        Dclassestamp = c.String(nullable: false, maxLength: 80),
                        Anosem = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 120),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Tipoprazo = c.String(nullable: false, maxLength: 80),
                        Datain = c.DateTime(nullable: false),
                        Datater = c.DateTime(nullable: false),
                        Datainaula = c.DateTime(nullable: false),
                        Datateraula = c.DateTime(nullable: false),
                        Datainnota = c.DateTime(nullable: false),
                        Dataternota = c.DateTime(nullable: false),
                        Dataresult = c.DateTime(nullable: false),
                        Fechado = c.Boolean(nullable: false),
                        DataFecho = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Dclassestamp);
            
            CreateTable(
                "dbo.Dclassel",
                c => new
                    {
                        Dclasselstamp = c.String(nullable: false, maxLength: 80),
                        Dclassestamp = c.String(nullable: false, maxLength: 80),
                        Turmastamp = c.String(nullable: false, maxLength: 80),
                        Turma = c.String(nullable: false, maxLength: 80),
                        Cursostamp = c.String(nullable: false, maxLength: 80),
                        Curso = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Dclasselstamp)
                .ForeignKey("dbo.Dclasse", t => t.Dclassestamp, cascadeDelete: true)
                .Index(t => t.Dclassestamp);
            
            AddColumn("dbo.Turmanota", "Fecho", c => c.Boolean(nullable: false));
            AddColumn("dbo.Turmanota", "Datafecho", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dclassel", "Dclassestamp", "dbo.Dclasse");
            DropIndex("dbo.Dclassel", new[] { "Dclassestamp" });
            DropColumn("dbo.Turmanota", "Datafecho");
            DropColumn("dbo.Turmanota", "Fecho");
            DropTable("dbo.Dclassel");
            DropTable("dbo.Dclasse");
        }
    }
}
