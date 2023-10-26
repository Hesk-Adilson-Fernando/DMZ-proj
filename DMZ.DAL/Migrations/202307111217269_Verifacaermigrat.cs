namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Verifacaermigrat : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TdocMat", "IX_X_Tdoc");
            AddColumn("dbo.Param", "NaoverificaNuit", c => c.Boolean(nullable: false));
            DropColumn("dbo.Stl", "OriStamp");
            DropTable("dbo.TdocMat");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TdocMat",
                c => new
                    {
                        TdocMatstamp = c.String(nullable: false, maxLength: 80),
                        Numdoc = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Sigla = c.String(nullable: false, maxLength: 80),
                        Defa = c.Boolean(nullable: false),
                        Inscricao = c.Boolean(nullable: false),
                        Matricula = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TdocMatstamp);
            
            AddColumn("dbo.Stl", "OriStamp", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Param", "NaoverificaNuit");
            CreateIndex("dbo.TdocMat", "Sigla", unique: true, name: "IX_X_Tdoc");
        }
    }
}
